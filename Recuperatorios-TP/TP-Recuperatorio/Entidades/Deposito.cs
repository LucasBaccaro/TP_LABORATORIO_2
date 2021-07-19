using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        
        private List<Articulo> articulos;

        private int espacioDisponible;

        public List<Articulo> Articulos { get => articulos; set => articulos = value; }
        public int EspacioDisponible { get => espacioDisponible; set => espacioDisponible = value; }

        /// <summary>
        /// Inicializo lista
        /// </summary>
        public Deposito()
        {
            this.Articulos = new List<Articulo>();
        }
        /// <summary>
        /// Constructor que recibe la capacidad
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Deposito(int espacioDisponible) : this()
        {
            this.EspacioDisponible = espacioDisponible;
        }
        /// <summary>
        /// Sobrecarga operador + (suma a la lista)
        /// </summary>
        /// <param name="depo"></param>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public static Deposito operator +(Deposito depo, Articulo articulo)
        {
            int bandera = 0;

            foreach (Articulo v in depo.articulos)
            {
                if (v == articulo)
                {
                    bandera = 1;
                    break;
                    throw new Exception();
                }
            }
            if (bandera == 0 && depo.Articulos.Count < depo.EspacioDisponible)
            {
                depo.Articulos.Add(articulo);
            }
            return depo;
        }
        /// <summary>
        /// Sobrecarga operador - (quita de la lista)
        /// </summary>
        /// <param name="depo"></param>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public static Deposito operator -(Deposito depo, Articulo articulo)
        {
            foreach (Articulo v in depo.Articulos)
            {
                if (v == articulo)
                {
                    depo.Articulos.Remove(articulo);
                    break;
                }
            }
            return depo;
        }
        /// <summary>
        /// quita de la lista utilizando indice
        /// </summary>
        /// <param name="depo"></param>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public static Deposito operator -(Deposito depo, int articulo)
        {

            depo.Articulos.RemoveAt(articulo);

            return depo;
        }

        /// <summary>
        /// Sobrecarga tostring, llamando datos existentes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("-------------------------------------------------------------------------------------------------------------------");
            foreach (Articulo item in this.Articulos)
            {
                str.AppendFormat($"{item.ToString()}\n");
                str.AppendLine("--------------------------------------------------------------------------------------------------------------------");
            }
            return str.ToString();
        }

    }


}
