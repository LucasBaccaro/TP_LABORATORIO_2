using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz que calcula Diametro de algun Articulo que necesite
    /// </summary>
    public interface IDiametro
    {
        double Ancho { get; set; }
        double Largo { get; set; }
        double CalcularDiametro();
    }

}
