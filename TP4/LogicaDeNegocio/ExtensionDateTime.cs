using System;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Esta clase implementa los temas:
    /// Tema 21 - Métodos de extensión
    /// </summary>
    public static class ExtensionDateTime
    {
        /// <summary>
        /// Formatea una fecha y hora como un dato de tipo long bajo el siguiente diseño
        /// AAMMDDHHmm / año, mes, dia, hora, minutos
        /// 2022/05/07 10:30 -> 2205071030
        /// </summary>
        /// <param name="fecha">fecha a formatear</param>
        /// <returns>fecha y hora como formato long</returns>
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
