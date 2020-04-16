using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiTestAccionaIT.Controllers
{
    public class Provincias
    {
        private const string URL = "https://apis.datos.gob.ar/georef/api/provincias";
        private Logger log = new Logger();

        //El metodo GetProvincias es el encargado de realizar la call a la api para obtener toda la informacion
        public string GetProvincias()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(URL);

                request.Method = "GET";

                var content = string.Empty;


                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            log.LogFile("Llamada a Api en GetProvincias a URL : " + URL);
                            content = sr.ReadToEnd();
                        }
                    }
                }

                log.LogFile("Respuesta de la llamada a Api en GetProvincias():" + content);
                return content;
            }
            catch (Exception ex)
            {
                log.LogFile("Exception en GetProvincias(): " + ex.Message);
                return "Error";

            }
        }

        public string GetLatLongProvincia(string provRequest)
        {

            var respuesta = "";
            var content = string.Empty;
            bool encontro = false;
            try
            {
                content = GetProvincias(); //content tendrá la información de la API
                if (content != "Error")
                {
                    var data = (JObject)JsonConvert.DeserializeObject(content);
                    var provincias = data["provincias"]; // Guardo solamente la parte de provincias

                    foreach (var item in provincias) // Loop en provincias para buscar la deseada, y luego obtener los datos solicitados
                    {

                        if (item["nombre"].ToString().ToUpper() == provRequest.ToUpper())
                        {
                            var nombre = item["nombre"].ToString();
                            var centroide = item["centroide"];
                            var lat = centroide["lat"].ToString();
                            var lon = centroide["lon"].ToString();
                            respuesta = "La provincia " + nombre + " tiene de lon: " + lon + " y tiene de lat: " + lat;
                            encontro = true;
                        }
                    }

                    if (!encontro)
                    {
                        respuesta = "No se encontró la provincia en cuestión, por favor verificar los datos buscados";
                    }

                }
                else
                {
                    respuesta = "No se pudo buscar las provincias, hubo un problema con la URL solicitada";
                }
                log.LogFile("Respuesta de GetLatLongProvincias() : " + respuesta);
                return respuesta;


            }
            catch (Exception ex)
            {
                log.LogFile("Exception en GetLatLongProvincia(): " + ex.Message);
                return "Error en la peticion de las provincias";

            }
        }
    }
}