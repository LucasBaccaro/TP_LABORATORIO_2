using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Remera))]
    [XmlInclude(typeof(Pantalon))]
    public abstract class Articulo
    {
        protected string talle;
        protected string codigoDeBarra;

        public string Talle { get => talle; set => talle = value; }
        public string CodigoDeBarra { get => codigoDeBarra; set => codigoDeBarra= value; }


        /// <summary>
        /// Constructor por defecto 
        /// </summary>
        public Articulo() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="talle">Recibe el color</param>
        /// <param name="codigoDeBarra">Recibe el codigo</param>
        public Articulo(string talle, string codigoDeBarra)
        {
            Talle = talle;
            CodigoDeBarra = codigoDeBarra;
        }

        /// <summary>
        /// Sobrecarga del == para decir que un articulo es igual a otro solamente si tienen el mismo codigo
        /// </summary>
        /// <param name="a">Articulo A</param>
        /// <param name="b">Articulo B</param>
        /// <returns></returns>
      
        public static bool operator ==(Articulo a, Articulo b)
        {
            return (a.CodigoDeBarra == b.CodigoDeBarra);
        }
        /// <summary>
        /// Sobrecarga obligatoria para el ==
        /// </summary>
        /// <param name="a">Articulo A</param>
        /// <param name="b">Articulo B</param>
        /// <returns></returns>
        public static bool operator !=(Articulo a, Articulo b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Mostrar estatico que muestra la informacion de dicho Articulo
        /// </summary>
        /// <param name="a">Recibe un articulo, con sus propiedades</param>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Codigo de Barra-> {this.CodigoDeBarra}\n  ");
            sb.AppendFormat($"Talle-> {this.Talle}\n  ");
            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            if(obj is Articulo)
            {
                return this == (Articulo)obj;
            }
            return false;
            
        }

    }
}
