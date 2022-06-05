using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio;

namespace TestUnitarios
{
    /// <summary>
    /// Parte del proyecto que contiene el tema:
    /// Tema 11 - Pruebas Unitarias
    /// </summary>
    [TestClass]
    public class TurnoTesting
    {
        [TestMethod]
        [ExpectedException(typeof(DatosInvalidosException))]
        [DataRow(77677677, "776", "Kyoma", "10485960")]
        [DataRow(77677677, "Hououin", "776", "10485960")]
        [DataRow(777677777, "Hououin", "Kyoma", "10485960")]
        [DataRow(7, "Hououin", "Kyoma", "10485960")]
        [DataRow(77677677, "Hououin", "Kyoma", "a")]
        [DataRow(77677677, "Hououin", "Kyoma", "1")]
        public void Constructor_CuandoAlgunoDeLosParametrosEsInvalido_LanzaDatosInvalidosException(int dni, string nombre, string apellido, string telefono)
        {
            //arrange
            DateTime fecha = DateTime.Now;
            float precio = 500;
            Turno.TipoConsulta tipo = Turno.TipoConsulta.Consulta;

            //act
            Turno turno = new Turno(fecha, precio, tipo, dni, telefono, nombre, apellido);
        }

        [TestMethod]
        public void Constructor_CuandoLosParametrosSonValidos_GeneraUnTurno()
        {
            //arrange
            int dni = 77677677;
            string nombre = "Hououin";
            string apellido = "Kyoma";
            string telefono = "10485960";
            DateTime fecha = DateTime.Now;
            float precio = 500;
            Turno.TipoConsulta tipo = Turno.TipoConsulta.Consulta;

            //act
            Turno turno = new Turno(fecha, precio, tipo, dni, telefono, nombre, apellido);

            //assert
            Assert.IsNotNull(turno);
        }

        [TestMethod]
        public void OperadorIgualdad_CuandoDosTurnosTienenLaMismaFecha_DevuelveTrue()
        {
            //arrange
            DateTime fecha = DateTime.Now;
            Turno.TipoConsulta tipo = Turno.TipoConsulta.Consulta;
            Turno turnoUno = new Turno(fecha, 500, tipo, 77677677, "10485960", "Hououin", "Kyoma");
            Turno turnoDos = new Turno(fecha, 600, tipo, 43333333, "39489911", "Rintaro", "Okabe");

            //assert
            Assert.IsTrue(turnoUno == turnoDos);
        }

        [TestMethod]
        public void OperadorIgualdad_CuandoDosTurnosTienenFechasDistintas_DevuelveFalse()
        {
            //arrange
            int dni = 77677677;
            string nombre = "Hououin";
            string apellido = "Kyoma";
            string telefono = "10485960";
            float precio = 500;
            Turno.TipoConsulta tipo = Turno.TipoConsulta.Consulta;
            DateTime fechaUno = DateTime.Now;
            DateTime fechaDos = DateTime.Now.AddDays(1);

            Turno turnoUno = new Turno(fechaUno, precio, tipo, dni, telefono, nombre, apellido); 
            Turno turnoDos = new Turno(fechaDos, precio, tipo, dni, telefono, nombre, apellido);

            //assert
            Assert.IsFalse(turnoUno == turnoDos);
        }

        [TestMethod]
        public void OperadorIgualdad_CuandoUnaListaDeTurnosYaTieneUnTurnoConLaMismaFecha_DevuelveTrue()
        {
            //arrange
            DateTime fecha = DateTime.Now;
            Turno.TipoConsulta tipo = Turno.TipoConsulta.Consulta;
            Turno turnoUno = new Turno(fecha, 500, tipo, 77677677, "10485960", "Hououin", "Kyoma");
            Turno turnoDos = new Turno(fecha, 600, tipo, 43333333, "39489911", "Rintaro", "Okabe");
            List<Turno> turnos = new List<Turno>();

            //act
            turnos.Add(turnoUno);

            //assert
            Assert.IsTrue(turnoDos == turnos);
        }

        [TestMethod]
        public void OperadorIgualdad_CuandoUnaListaDeTurnosNoTieneUnTurnoConLaMismaFecha_DevuelveFalse()
        {
            //arrange
            DateTime fechaUno = DateTime.Now;
            DateTime fechaDos = fechaUno.AddHours(1);
            Turno.TipoConsulta tipo = Turno.TipoConsulta.Consulta;

            Turno turnoUno = new Turno(fechaUno, 500, tipo, 77677677, "10485960", "Hououin", "Kyoma");
            Turno turnoDos = new Turno(fechaDos, 600, tipo, 43333333, "39489911", "Rintaro", "Okabe");
            List<Turno> turnos = new List<Turno>();

            //act
            turnos.Add(turnoUno);

            //assert
            Assert.IsFalse(turnoDos == turnos);
        }
    }
}
