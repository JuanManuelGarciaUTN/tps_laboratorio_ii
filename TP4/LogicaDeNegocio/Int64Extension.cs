using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Esta clase implementa los temas:
    /// Tema 21 - Métodos de extensión
    /// </summary>
    public static class Int64Extension
    {
        /// <summary>
        /// Dado un long que representa una fecha y hora.
        /// Genera una nueva instancia de DateTime en base al mismo
        /// 2205071030 -> 2022/05/07 10:30:00
        /// </summary>
        /// <param name="fecha">fecha y hora en formato long</param>
        /// <returns>fecha y hora segun el formato base</returns>
        public static DateTime ObtenerFecha(this Int64 fecha)
        {
            return new DateTime(fecha.ObtenerAnio(), fecha.ObtenerMes(), fecha.ObtenerDia(), fecha.ObtenerHora(), fecha.ObtenerMinutos(), 0);
        }
        public static int ObtenerAnio(this Int64 fecha)
        {
            return (int)(fecha / 100000000 + 2000); 
        }

        public static int ObtenerMes(this Int64 fecha)
        {
            return (int)(fecha / 1000000 % 100);
        }

        public static int ObtenerDia(this Int64 fecha)
        {
            return (int)(fecha / 10000 % 100);
        }

        public static int ObtenerHora(this Int64 fecha)
        {
            return (int)(fecha / 100 % 100);
        }

        public static int ObtenerMinutos(this Int64 fecha)
        {
            return (int)(fecha % 100);
        }
    }
}
