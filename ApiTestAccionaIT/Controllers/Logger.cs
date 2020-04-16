using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTestAccionaIT.Controllers
{
    public class Logger
    {
        public void LogFile(string evento)
        {
            var path = @".\log.txt"; // al correr el test, lo ubica en: UnitTest\bin\Debug\netcoreapp3.1
            StreamWriter log;
            if (!File.Exists(path))
            {
                log = new StreamWriter(path);
            }
            else
            {
                log = File.AppendText(path);
            }
            // Write to the file:
            log.WriteLine(DateTime.Now + " - " + evento);

            // Close the stream:
            log.Close();
        }
    }
}