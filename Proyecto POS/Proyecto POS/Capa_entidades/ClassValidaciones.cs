using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_entidades
{
    //Se crea la clase de validaciones y se deja publica
    public static class ClassValidaciones
    {
        //Validar que el dato sea entero
        public static bool EsEntero(string s)
        {
            int numero;
            return int.TryParse(s, out numero); //Metodo para connvertir una cadena a numeros enteros
        }
        //Validar que el dato sea decimal
        public static bool EsDecimal(string s)
        { 
            decimal numero;
            return decimal.TryParse(s, out numero);
        }
        //Validar direccion de correo electronico
        public static bool EsCorreoValido(string email)
        { 
            if (string.IsNullOrWhiteSpace(email)) //Verefica si el correo esta vacio
                return false;
            //Exprecion regular para validar correo
            var patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron); //Metodo que compara la cadena con el patron

        }
    }
}
