using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoCubierto
    {
        Tenedor,
        Cuchillo,
        Cuchara
    }
    public class Cubierto : Articulo
    {
        protected ETipoCubierto tipoCubierto;
        public Cubierto(double cantidad,string codigo,ETipoCubierto tipoCubierto):base(cantidad,codigo)
        {
            this.tipoCubierto = tipoCubierto;
        }

        public override bool Equals(object obj)
        {
            return obj is Cubierto;
        }

        public static bool operator ==(Cubierto a, Cubierto b)
        {
            return (a.Codigo == b.Codigo);
        }

        public static bool operator !=(Cubierto a, Cubierto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{(string)(Articulo)this}");
            sb.AppendFormat($"Tipo cubierto: {this.tipoCubierto}\n");

            return sb.ToString();
        }

        

    }
}
