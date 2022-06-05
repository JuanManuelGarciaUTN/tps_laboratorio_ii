using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class Autentificador
    {
        //atributos
        private static string usuario;
        private static string contrasenia;

        //constructor
        static Autentificador()
        {
            usuario = "Odontologia";
            contrasenia = "SatoshiNakamoto";
        }

        //metodos
        /// <summary>
        /// Verifica que los string recibidos correspondan con la contraseña y el usuario correcto
        /// </summary>
        /// <param name="usuarioIngresado"></param>
        /// <param name="contraseniaIngresada"></param>
        /// <returns>true si los datos son correctos - false si no son correctos</returns>
        public static bool Autentificar(string usuarioIngresado, string contraseniaIngresada)
        {
            return usuario == usuarioIngresado && contrasenia == contraseniaIngresada;
        }
    }
}
