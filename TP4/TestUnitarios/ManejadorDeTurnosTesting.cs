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
        public void Contructor_CuandoElArchivoDelPathRecibidoNoExiste_GeneraUnArchivoNuevoConValoresPorDefecto()
        {
            //arrange
            string pathPrecios = "./archivoTampocoExiste";
            bool preciosExiste;
            bool preciosTieneFormatoPorDefecto = false;

            //act
            ManejadorDeTurnos manejadorDeTurnos = new ManejadorDeTurnos(pathPrecios);


            preciosExiste = File.Exists(pathPrecios);
            File.Delete(pathPrecios);

            if(manejadorDeTurnos.Precios.Count == 4)
            {
                preciosTieneFormatoPorDefecto = true;
            }

            //assert
            Assert.IsTrue(preciosExiste && preciosTieneFormatoPorDefecto);
        }
    }
}
