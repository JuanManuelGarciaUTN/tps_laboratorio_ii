using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio;
using System.IO;


namespace TestUnitarios
{
    /// <summary>
    /// Parte del proyecto que contiene el tema:
    /// Tema 11 - Pruebas Unitarias
    /// </summary>
    [TestClass]
    public class ManejadorDeTurnosTesting
    {
        [TestMethod]
        public void Contructor_CuandoElArchivoDelPathRecibidoNoExite_GeneraUnArchivoNuevoConValoresPorDefecto()
        {
            //arrange
            string pathTurnos = "./archivoNoExiste";
            string pathPrecios = "./archivoTampocoExiste";
            bool turnosExiste;
            bool preciosExiste;
            bool turnosTieneFormatoPorDefecto = false;
            bool preciosTieneFormatoPorDefecto = false;

            //act
            ManejadorDeTurnos manejadorDeTurnos = new ManejadorDeTurnos(pathTurnos, pathPrecios);

            turnosExiste = File.Exists(pathTurnos);
            File.Delete(pathTurnos);

            preciosExiste = File.Exists(pathPrecios);
            File.Delete(pathPrecios);

            if(0 == manejadorDeTurnos.ObtenerTurnosDelDia(DateTime.Now).Count)
            {
                turnosTieneFormatoPorDefecto = true;
            }
            if(manejadorDeTurnos.Precios.Count == 4)
            {
                preciosTieneFormatoPorDefecto = true;
            }

            //assert
            Assert.IsTrue(turnosExiste && preciosExiste && turnosTieneFormatoPorDefecto && preciosTieneFormatoPorDefecto);
        }
    }
}
