using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Entidades
{
    /// <summary>
    /// Enumerado de los tipos de materiales
    /// </summary>
    public enum EtipoMaterial
    {
        Algodon,
        Terciopelo
    }
    [Serializable]
    [XmlInclude(typeof(Pantalones))]
    [XmlInclude(typeof(Remeras))]
   

    ///<summary>
    ///Clase abstracta articulo
    ///</summary>
    public abstract class Articulo
    {
       

        protected string color;
        protected string codigo;
        protected EtipoMaterial tipoMaterial;

        public string Color { get => color; set => color = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public EtipoMaterial TipoMaterial { get => tipoMaterial; set => tipoMaterial = value; }


        /// <summary>
        /// Constructor por defecto 
        /// </summary>
        public Articulo() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="color">Recibe el color</param>
        /// <param name="codigo">Recibe el codigo</param>
        /// <param name="tipoMaterial">Recibe el tipo de material</param>
        public Articulo(string color, string codigo, EtipoMaterial tipoMaterial)
        {
            Color = color;
            Codigo = codigo;
            TipoMaterial = tipoMaterial;
        }

        /// <summary>
        /// Sobrecarga del Equals para decir que esto es un OBJ
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this == (Articulo)obj;
        }
        /// <summary>
        /// Sobrecarga del == para decir que un articulo es igual a otro solamente si tienen el mismo codigo
        /// </summary>
        /// <param name="a">Articulo A</param>
        /// <param name="b">Articulo B</param>
        /// <returns></returns>
        public static bool operator ==(Articulo a, Articulo b)
        {
            return (a.Codigo == b.Codigo);
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
        private static string Mostrar(Articulo a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Color-->{a.Color}\n");
            sb.AppendFormat($"Codigo-->{a.Codigo}\n");
            return sb.ToString();
        }
        /// <summary>
        /// Explicit que se usa para poder sobrescribir el Tostring()
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator string(Articulo p)
        {
            return Articulo.Mostrar(p);
        }


    }
}
