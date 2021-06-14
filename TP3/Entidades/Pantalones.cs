using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Pantalones : Articulo,IDiametro
    {
        protected double ancho;
        protected double largo;
        protected double diametro;

        public double Diametro { get => diametro; set => diametro = value; }
        public double Ancho { get => ancho; set => ancho = value; }
        public double Largo { get => largo; set => largo = value; }

        /// <summary>
        /// Constructor sin parametros para serializar luego
        /// </summary>
        public Pantalones() { }
        /// <summary>
        /// Constructor que recibe de la clase base,Articulo, las propiedades y ademas, toma ancho y largo para su interfaz
        /// </summary>
        /// <param name="color"></param>
        /// <param name="codigo"></param>
        /// <param name="tipoMaterial"></param>
        /// <param name="ancho"></param>
        /// <param name="largo"></param>
        public Pantalones(string color, string codigo,EtipoMaterial tipoMaterial,double ancho,double largo) : base(color,codigo,tipoMaterial)
        {
            Ancho = ancho;
            Largo = largo;
            this.diametro = ((IDiametro)this).CalcularDiametro();
        }

        /// <summary>
        /// Override del tostring para mostrar datos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("##PANTALON##\n");
            sb.AppendFormat((Articulo)this);
            sb.AppendFormat($"Tipo material-->{this.tipoMaterial}\n");
            sb.AppendFormat($"Ancho-->{this.ancho}\n");
            sb.AppendFormat($"Largo-->{this.largo}\n");
            sb.AppendFormat($"Diametro-->{this.diametro}\n");
            
            return sb.ToString();
        }
        double IDiametro.Ancho { get; set; }
        double IDiametro.Largo{ get; set; } 

        
        /// <summary>
        /// Metodo que calcula el diametro, tomando el ancho y largo
        /// </summary>
        /// <returns></returns>
        double IDiametro.CalcularDiametro()
        {
            return (this.Ancho * this.Largo);
        }


    }
}
