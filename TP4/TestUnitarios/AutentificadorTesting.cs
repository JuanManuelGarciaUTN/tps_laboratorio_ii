using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio;

namespace TestUnitarios
{
    /// <summary>
    /// Parte del proyecto que contiene el tema:
    /// Tema 11 - Pruebas Unitarias
    /// </summary>
    [TestClass]
    public class AutentificadorTesting
    {
        [TestMethod]
        public void Autentificar_CuandoAmbosDatosSonCorrectos_DevuelveTrue()
        {
            //arrange
            string usuario = "Odontologia";
            string contrasenia = "SatoshiNakamoto";

            //assert
            Assert.IsTrue(Autentificador.Autentificar(usuario, contrasenia));
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("satoshiNakamoto")]
        [DataRow("satoshinakamoto")]
        [DataRow("ElPsyKongroo")]
        public void Autentificar_CuandoLaContraseniaEsIncorrecta_DevuelveFalse(string contrasenia)
        {
            //arrange
            string usuario = "Odontologia";

            //assert
            Assert.IsFalse(Autentificador.Autentificar(usuario, contrasenia));
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("odontologia")]
        [DataRow("Odontología")]
        [DataRow("ZaZombi")]
        public void Autentificar_CuandoElUsuarioEsIncorrecto_DevuelveFalse(string usuario)
        {
            //arrange
            string contrasenia = "SatoshiNakamoto";

            //assert
            Assert.IsFalse(Autentificador.Autentificar(usuario, contrasenia));
        }
    }
}
