using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTestAccionaIT.Controllers
{
    public class LoginController : ApiController
    {
        Login login = new Login();

        //../api/login?usuario=user&password=123
        public string GetLogin(string usuario, string password)
        {
            return login.LoguearUsuer(usuario, password);
        }
    }
}
