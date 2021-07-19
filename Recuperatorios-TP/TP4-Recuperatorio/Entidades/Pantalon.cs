using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Etipo
    {
        Corto,
        Largo,
    }
    [Serializable]
    public class Pantalon : Articulo
    {
        protected Etipo tipo;
        public Etipo Tipo { get => tipo; set => tipo= value; }

        public Pantalon() { }
        /// <summary>
        /// Constructor recibe talle y codigo de la clase base, articulo
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="talle"></param>
        /// <param name="codigoDeBarra"></param>
        public Pantalon(Etipo tipo, string talle, string codigoDeBarra) : base(talle, codigoDeBarra)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// metodo privado, mostrar datos de pantalon
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Pantalon: \n ");
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"Tipo-> {this.Tipo}\n  ");
            return sb.ToString();
        }
        /// <summary>
        /// Tostring del metodo privado mostrar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj is Pantalon)
            {
                return this == (Pantalon)obj;
            }
            return false;

        }
    }
}
