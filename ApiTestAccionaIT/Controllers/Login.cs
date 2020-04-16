using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTestAccionaIT.Controllers
{
    public class Login
    {
        public Usuario userLogin = new Usuario();
        //private JavaScriptSerializer serializer = new JavaScriptSerializer();
        private string loginResponse = "";
        private Logger log = new Logger();

        public string LoguearUsuer(string usuario, string password)
        {
            try
            {
                loginResponse = userLogin.ValidarUserLogin(usuario, password);
                log.LogFile("Intenta Login con respuesta: " + loginResponse);
            }
            catch (Exception ex)
            {
                loginResponse = "{" + '"' + "Error" + '"' + ":" + '"' + "Hubo un error en el sistema, contactar al administrador" + '"' + "}";
                log.LogFile("Exception en Loguear User: " + ex.Message);
            }
            finally
            {
                if (loginResponse == "")
                {
                    loginResponse = "{" + '"' + "Error" + '"' + ":" + '"' + "Hubo un error en el sistema, contactar al administrador" + '"' + "}";
                }

            }
            return loginResponse;
        }
    }
}