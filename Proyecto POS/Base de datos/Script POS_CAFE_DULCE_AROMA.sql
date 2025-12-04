create database POS_CAFE_DULCE_AROMA;
use POS_CAFE_DULCE_AROMA;
DROP TABLE Usuarios;
GO
CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    ClaveHash VARCHAR(64) NOT NULL, -- SHA-256 => 64 hex chars
    Rol VARCHAR(20) NOT NULL,
    Estado BIT NOT NULL DEFAULT 1,
    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE()
);
GO
-- Inserción usuarios por defecto (hashes SHA-256 de las contraseñas)
-- admin -> admin123
-- cajero -> cajero123

INSERT INTO Usuario (NombreUsuario, ClaveHash, Rol, Estado)
VALUES 
('admin',  '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Admin', 1),
('cajero', '1ed4353e845e2e537e017c0fac3a0d402d231809b7989e90da15191c1148a93f', 'Cajero', 1)
GO
-- Opcional: ejemplo de consulta para verificar
SELECT IdUsuario, NombreUsuario, Rol, Estado, FechaCreacion FROM Usuario;
GO


--Tablas independientes
create table Categorias(
id int primary key identity(1,1),
nombre varchar(100) not null
);
INSERT INTO Categorias (nombre) VALUES 
('Café en Grano'),
('Café Molido'),
('Café Especial'),
('Accesorios');

create table Metodos_pago(
id int primary key identity(1,1),
nombre varchar(100) not null
);
INSERT INTO Metodos_pago (nombre) VALUES 
('Efectivo'),
('Tarjeta de Crédito'),
('Tarjeta de Débito');

create table Clientes(
id int primary key identity(1,1),
nombre varchar(100) not null,
apellido varchar(100) not null,
dui varchar(25) not null,
telefono varchar(25) not null,
correo varchar(100) not null,
estado bit not null
);
INSERT INTO Clientes (nombre, apellido, dui, telefono, correo, estado) VALUES 
('Juan', 'Pérez', '12345678-9', '7890-1234', 'juan.perez@email.com',1),
('María', 'González', '98765432-1', '7890-5678', 'maria.gonzalez@email.com', 1),
('Carlos', 'Rodríguez', '11223344-5', '7890-9012', 'carlos.rodriguez@email.com', 1),
('Ana', 'Martínez', '55667788-9', '7890-3456', 'ana.martinez@email.com', 1);

--Para login
create table Usuarios(
id int primary key identity(1,1),
nombre varchar(100) not null unique,
contrasenia varbinary(64) not null,
rol varchar(100) not null,
estado bit not null
);
INSERT INTO Usuarios (nombre, contrasenia, rol, estado) VALUES 
('admin', HASHBYTES('SHA2_256', 'admin123'), 'Administrador', 1);

--Tablas independientes
create table Productos(
id int primary key identity(1,1),
nombre varchar(100) not null,
precio decimal(10,2) not null,
stock int not null,
estado bit not null,
id_categoria int,
constraint FK_Productos_Categorias foreign key (id_categoria) references Categorias(id),
);

INSERT INTO Productos (nombre, precio, stock, estado, id_categoria) VALUES 
('Café Arábica Premium 1lb', 12.99, 150, 1, 1),
('Café Pacamara 1lb', 18.50, 100, 1, 1),
('Café Bourbon 1lb', 15.99, 120, 1, 1),
('Café Molido Suave 1lb', 11.99, 180, 1, 2),
('Café Molido Fuerte 1lb', 11.99, 160, 1, 2),
('Café Molido Espresso 1lb', 14.99, 110, 1, 2),
('Café Cappuccino 16oz', 4.50, 300, 1, 3),
('Café Latte 16oz', 4.50, 300, 1, 3),
('Café Americano 12oz', 3.00, 350, 1, 3),
('Filtros de Papel x100', 3.50, 500, 1, 4),
('Prensa Francesa 34oz', 24.99, 45, 1, 4),
('Taza Térmica 16oz', 12.99, 80, 1, 4);

create table Ventas(
id int primary key identity(1,1),
fecha date not null,
monto_total decimal(10,2) not null,
id_cliente int,
id_metodo_pago int,
constraint FK_Ventas_Clientes foreign key (id_cliente) references Clientes(id),
constraint FK_Ventas_Metodos_pago foreign key (id_metodo_pago) references Metodos_pago(id)
);
INSERT INTO Ventas(fecha, monto_total, id_cliente, id_metodo_pago) VALUES 
('2024-11-01', 38.48, 4, 2),    
('2024-11-05', 13.50, 3, 1),    
('2024-11-10', 89.94, 1, 3),    
('2024-11-15', 22.50, 2, 1);

--Tablas intermedias
create table Detalles_venta(
id int primary key identity(1,1),
cantidad int not null,
precio_unitario decimal(10,2) not null,
sub_total decimal(10, 2) not null,
id_venta int,
id_producto int,
constraint FK_Detalles_venta_Ventas foreign key (id_venta) references Ventas(id),
constraint FK_Detalles_venta_Productos foreign key (id_producto) references Productos(id)
);
INSERT INTO Detalles_venta(cantidad, precio_unitario, sub_total, id_venta, id_producto) VALUES 
(2, 12.99, 25.98, 8, 1),   
(1, 12.50, 12.50, 8, 12),
(3, 4.50, 13.50, 9, 7),
(3, 11.99, 35.97, 10, 4),   
(2, 11.99, 23.98, 10, 5),   
(1, 29.99, 29.99, 10, 11),
(2, 4.50, 9.00, 11, 11),   
(3, 4.50, 13.50, 9, 9);

-- IMPORTANTE: Usamos ALTER, no CREATE, porque el procedimiento ya existe.
ALTER PROCEDURE sp_reporte_ventas_periodo
    @FechaInicio DATE,
    @FechaFin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        v.id,
        v.fecha,
        c.nombre AS Cliente,
        p.nombre,
        dv.cantidad,
        
        -- ESTA ES LA CLAVE:
        -- Tomamos tu columna 'precio_unitario' y la renombramos temporalmente
        -- a 'PrecioUnitario' para que tu reporte la reconozca.
        dv.precio_unitario AS PrecioUnitario, 
        
        (dv.cantidad * dv.precio_unitario) AS SubTotal,
        v.monto_total
    FROM Ventas v
    INNER JOIN Clientes c ON v.id_cliente = c.id
    INNER JOIN Detalles_venta dv ON dv.id_venta = v.id
    INNER JOIN Productos p ON p.id = dv.id_producto
    WHERE CONVERT(date, v.fecha) BETWEEN @FechaInicio AND @FechaFin
    ORDER BY v.fecha ASC;
END
GO


