using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EColores
    {
        Negro,
        Azul,
        Verde
    }
    [Serializable]
    public class Remera : Articulo
    {
        public EColores color;
        public EColores Color { get => color; set => color= value; }

        public Remera() { }
        /// <summary>
        /// constructor de remera, recibe el talle y codigo de barra de la clase abstracta
        /// </summary>
        /// <param name="color"></param>
        /// <param name="talle"></param>
        /// <param name="codigoDeBarra"></param>
        public Remera(EColores color,string talle,string codigoDeBarra) : base(talle,codigoDeBarra)
        {
            this.color = color;
        }
        /// <summary>
        /// metodo privado, mostrar datos de la remera
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Remera: \n ");
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"Color-> {this.color}\n  ");
            return sb.ToString();
        }
        /// <summary>
        /// Metodo tostring,llama al metodo privado mostrar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            if (obj is Remera)
            {
                return this == (Remera)obj;
            }
            return false;

        }
    }
}
