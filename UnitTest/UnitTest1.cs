using NUnit.Framework;
using ApiTestAccionaIT.Controllers;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLogin()
        {
            LoginController lController = new LoginController();
            string respuestaLogin = lController.GetLogin("user", "123");
            string respuestaLoginEsperada = "{" + '"' + "user" + '"' + ":" + '"' + "user" + '"' + "," + '"' + "password" + '"' + ":" + '"' + "123" + '"' + "," + '"' + "email" + '"' + ":" + '"' + "usuarioaccionatest@gmail.com" + '"' + "," + '"' + "nombre" + '"' + ":" + '"' + "Usuario" + '"' + "," + '"' + "apellido" + '"' + ":" + '"' + "Acciona" + '"' + "}";
            Assert.AreEqual(respuestaLoginEsperada, respuestaLogin);

        }

        [Test]
        public void TestProvincia()
        {
            ProvinciaController pController = new ProvinciaController();
            string respuestaProvincia = pController.GetProvincia("Chaco");
            string respuestaProvinciaEsperada = "La provincia Chaco tiene de lon: -60.7658307438603 y tiene de lat: -26.3864309061226";
            Assert.AreEqual(respuestaProvinciaEsperada, respuestaProvincia);
        }

    }
}