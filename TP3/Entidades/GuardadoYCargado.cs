using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class GuardadoYCargado
    {
        public string CargarInfoClass(Deposito<Articulo> midepo)
        {
            try
            {
                string rutaArchivo = string.Empty;

                if (File.Exists(rutaArchivo))
                {
                    using (XmlTextReader auxArchivoAleer = new XmlTextReader(rutaArchivo))
                    {
                        XmlSerializer auxLector = new XmlSerializer(typeof(Deposito<Articulo>));

                        midepo = (Deposito<Articulo>)auxLector.Deserialize(auxArchivoAleer);
                    }
                }
                else
                {
                    Console.WriteLine("No hay datos en el sistema");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw;
            }
            return midepo.ToString();
        }


        public string GuardarInfoClass(Deposito<Articulo> midepo)
        {
            try
            {
                if (midepo.Cantidad == 0)
                {
                    Console.WriteLine("No hay datos para guardar");
                }
                else
                {
                    Random random = new Random();
                    string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "Historial del dia "+DateTime.Now.ToString("dd-M-hh_mm_ss ")+".xml";
                    using (XmlTextWriter auxArchivo = new XmlTextWriter(rutaArchivo, Encoding.UTF8))
                    {
                        XmlSerializer auxEscritor = new XmlSerializer(typeof(Deposito<Articulo>));
                        auxEscritor.Serialize(auxArchivo, midepo);
                     
                        Console.WriteLine("Guardado con exito");
                        
                    }
                }
              
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return midepo.ToString();
        }

    }

   
}
