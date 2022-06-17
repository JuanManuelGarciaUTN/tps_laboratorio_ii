using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio;

namespace TestUnitarios
{
    [TestClass]
    public class DateTimeTesting
    {
        [TestMethod]
        [DataRow(2011, 11, 11, 11, 11, 1111111111)]
        [DataRow(2022, 11, 11, 11, 11, 2211111111)]
        [DataRow(2050, 11, 11, 11, 11, 5011111111)]
        [DataRow(2011, 1, 1, 11, 0, 1101011100)]
        public void DateTimeObtenerFormatoFechaHoraLong_RecibeUnaFecha_DevuelveUnLongFormatoAnioMesDiaHoraMinutos(int anio, int mes, int dia, int hora, int minutos, long fechaEnFormato)
        {
            DateTime fecha = new DateTime(anio, mes, dia, hora, minutos, 0);
            long expected = fechaEnFormato;

            //act
            long actual = fecha.ObtenerFormatoFechaHoraLong();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
