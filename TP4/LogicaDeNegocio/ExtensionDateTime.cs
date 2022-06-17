using System;

namespace LogicaDeNegocio
{
    public static class ExtensionDateTime
    {
        public static long ObtenerFormatoFechaHoraLong(this DateTime fecha)
        {
            long fechaEnFormato = 0;
            fechaEnFormato += fecha.Minute;
            fechaEnFormato += fecha.Hour  * 100;
            fechaEnFormato += fecha.Day   * 10000;
            fechaEnFormato += fecha.Month * 1000000;
            fechaEnFormato += (fecha.Year - 2000) * 100000000L;

            return fechaEnFormato;
        }
    }
}
