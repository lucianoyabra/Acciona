using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTestAccionaIT.Controllers
{
    public class Usuario
    {

        public string user;
        public string password;
        public string email;
        public string nombre;
        public string apellido;
        private Logger log = new Logger();

        public Usuario()
        {
            this.user = "user";
            this.password = "123";
            this.email = "usuarioaccionatest@gmail.com";
            this.nombre = "Usuario";
            this.apellido = "Acciona";
        }

        public string ValidarUserLogin(string user, string password)
        {

            Usuario logUser = new Usuario();
            //JavaScriptSerializer serial = new JavaScriptSerializer();
            string response = "";
            try
            {
                if (user != null && password != null)
                {
                    if (user != logUser.user)
                    {
                        //Usuario incorrecto
                        response = "{" + '"' + "Error" + '"' + ":" + '"' + "Error en el Login, el Usuario no coincide" + '"' + "}";
                    }
                    else
                    {
                        if (password != logUser.password)
                        {
                            //Password Incorrecta
                            response = "{" + '"' + "Error" + '"' + ":" + '"' + "Error en el Login, la contraseña no coincide." + '"' + "}";
                        }
                        else
                        {
                            //Login Correcto
                            response = JsonConvert.SerializeObject(logUser).ToString();
                            //response = ;
                        }
                    }
                }
                else
                {
                    //Login incorrecto user o pass null
                    response = "{" + '"' + "Error" + '"' + ":" + '"' + "Error en el Login, el User o Password no pueden ser nulos" + '"' + "}";
                }
                log.LogFile("Validación de datos en ValidarUserLogin con respuesta: " + response);
            }
            catch (Exception ex)
            {
                response = "{" + '"' + "Error: Hubo un error en el sistema, contactar al administrador" + '"' + "}";
                log.LogFile("Exception en ValidarUserLogin: " + ex.Message);
            }
            finally
            {
                if (response == "")
                {
                    response = "{" + '"' + "Error: Hubo un error en el sistema, contactar al administrador" + '"' + "}";
                }

            }
            return response;

        }
    }
}