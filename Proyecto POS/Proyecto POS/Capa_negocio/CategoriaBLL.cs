using Proyecto_POS.Capa_datos;
using Proyecto_POS.Capa_entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_negocio
{
    public class CategoriaBLL
    {
        CategoriaDAL dal = new CategoriaDAL();
        public DataTable Listar()
        {
            return dal.Listar();
        }

        private void ValidarCategoria(Categorias c, bool esEdicion = false)
        {
            // 1. Campo obligatorio
            if (string.IsNullOrWhiteSpace(c.nombre))
                throw new Exception("El nombre de la categoría es obligatorio.");

            // 2. Longitud
            if (c.nombre.Length > 50)
                throw new Exception("El nombre no debe superar los 50 caracteres.");

            // 3. Validación de duplicados
            if (!esEdicion) // Caso: INSERTAR
            {
                if (dal.ExisteNombre(c.nombre))
                    throw new Exception("Ya existe una categoría con ese nombre.");
            }
            else // Caso: EDITAR
            {
                if (dal.ExisteNombreEnOtraCategoria(c.nombre, c.id))
                    throw new Exception("Ya existe otra categoría con ese nombre.");
            }
        }
        public int Guardar(Categorias c)
        {
            // Si el ID es 0 → INSERTAR
            if (c.id == 0)
            {
                ValidarCategoria(c, esEdicion: false);
                return dal.Insertar(c);
            }
            else
            {
                ValidarCategoria(c, esEdicion: true);

                bool actualizado = dal.Actualizar(c);

                if (!actualizado)
                    throw new Exception("No se pudo actualizar la categoría.");

                return c.id; // Devuelve el mismo ID
            }
        }
        public bool Eliminar(int id)
        {
            // Validación de FK ANTES de intentar eliminar
            if (dal.TieneProductosAsociados(id))
                throw new Exception("No se puede eliminar esta categoría porque tiene productos asociados.");

            // Si no tiene dependencias, eliminar
            return dal.Eliminar(id);

        }
        public DataTable Buscar(string filtro)
        {
            return dal.Buscar(filtro);
        }
    }
}
