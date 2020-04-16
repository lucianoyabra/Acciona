using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTestAccionaIT.Controllers
{
    
    public class ProvinciaController : ApiController
    {
        Provincias provincia = new Provincias();
        //../api/provincia?provinciaReq=chaco
        public string GetProvincia(string provinciaReq)
        {
            return provincia.GetLatLongProvincia(provinciaReq);
        }
    }
}
