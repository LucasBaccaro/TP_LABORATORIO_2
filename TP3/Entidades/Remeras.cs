using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Remeras : Articulo
    {
        protected string talle;
        public string Talle { get => talle; set => talle= value; }
        /// <summary>
        /// Constructor sin parametros para serializar a futuro
        /// </summary>
        public Remeras() { }
        /// <summary>
        /// Consturctor que toma parametros de la clase base y ademas, toma talle.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="codigo"></param>
        /// <param name="tipoMaterial"></param>
        /// <param name="talle"></param>
        public Remeras(string color,string codigo,EtipoMaterial tipoMaterial,string talle):base(color,codigo,tipoMaterial)
        {
            Talle = talle;
        }

        /// <summary>
        /// Override del Tostring para la muestra de datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("##REMERA##\n");
            sb.AppendFormat((Articulo)this);
            sb.AppendFormat($"Tipo Material-->{this.tipoMaterial}\n");
            sb.AppendFormat($"Talle-->{this.talle}\n");
            return sb.ToString();
        }
        
    }
}
