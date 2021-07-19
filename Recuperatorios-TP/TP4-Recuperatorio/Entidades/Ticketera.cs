using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticketera
    {
        public static bool ImprimirFactura(Pantalon p)
        {
            bool retorno = false;

            try
            {
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\pantalones.log", true);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(p.ToString());

                sw.Close();
                retorno = true;
            }
            catch (Exception)
            {

            }
            return retorno;
        }
    }
}
