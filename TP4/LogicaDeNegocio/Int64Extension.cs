using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class Int64Extension
    {
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

        public static DateTime ObtenerFecha(this Int64 fecha)
        {
            return new DateTime(fecha.ObtenerAnio(), fecha.ObtenerMes(), fecha.ObtenerDia(), fecha.ObtenerHora(), fecha.ObtenerMinutos(), 0);
        }
    }
}
