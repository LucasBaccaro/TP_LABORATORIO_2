using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Remera))]
    [XmlInclude(typeof(Pantalon))]
    public class Deposito<T> : ISerializar_Deserializar
    {

        public int Cantidad { get => _lista.Count; }

        private int capacidadMaxima;

        public delegate void EventoArticulo(Deposito<T> caja, EventArgs e);
        public event EventoArticulo Evento;

        private List<T> _lista;
        public List<T> ListaDeposito { get => this._lista; set => this._lista = value; }
        public int Capacidad { get => this.capacidadMaxima; set => capacidadMaxima = value; }

        /// <summary>
        /// Constructor por defecto para poder serializar
        /// </summary>
        public Deposito() { }
        /// <summary>
        /// Constructorque recibe la capacidade inicializa lista generica
        /// </summary>
        /// <param name="capacidad"></param>
        public Deposito(int capacidad)
        {
            ListaDeposito = new List<T>();
            Capacidad = capacidad;
        }
        /// <summary>
        /// Metodo que obtiene indice
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int GetIndice(T a)
        {
            int retorno = -1;
            int flag = 0;

            foreach (T item in _lista)
            {
                if (item.Equals(a))
                {
                    retorno = flag;
                    break;
                }
                flag += 1;
            }

            return retorno;
        }
        /// <summary>
        /// Metodo que obtiene indice
        /// </summary>
        /// <param name="aux"></param>
        /// <returns></returns>
        public int GetIndice(int aux)
        {
            return aux;
        }

        /// <summary>
        /// Sobrecarga del + que agrega un objeto a la lista generica
        /// </summary>
        /// <param name="d"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;

            if(d.ListaDeposito.Count < d.Capacidad)
            {
                if (d.GetIndice(a) == -1)
                {
                    d._lista.Add(a);

                    if (a is Pantalon && d.Evento != null ) 
                    {
                        d.Evento(d, new EventArgs());
                    }
                    retorno = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                throw new NoHayLugarException();
            }

            
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del metodo - que elimina un objeto de la lista generica
        /// </summary>
        /// <param name="d"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d.GetIndice(a) != -1 )
            {
                d._lista.RemoveAt(d.GetIndice(a));
                retorno = true;
            }
            return retorno;
        }
        public static Deposito<T> operator -(Deposito<T> d, int a)
        {
            d._lista.RemoveAt(a);
            return d;
        }

        /// <summary>
        /// Override del tostring para mostrar, los datos de Articulo + Los datos de la lista
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (T item in this._lista)
            {
                str.AppendFormat($"{item.ToString()}\n");
            }

            return str.ToString();
        }

        /// <summary>
        /// Metodo remover
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Remover(T a)
        {
            return this - a;
        }

        /// <summary>
        /// Metodo remover por index
        /// </summary>
        /// <param name="a"></param>
        /// <param name="aux"></param>
        /// <returns></returns>
        public Deposito<T> Remover(Deposito<T> a, int aux)
        {
            return a - aux;
        }

        /// <summary>
        /// Metodo agregar
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Agregar(T a)
        {
            return this + a;
        }

        public string Path
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                path += "//TP_LABORATORIO_2-main//TP4-Recuperatorio//DepoSerializado.xml";

                return path;

            }
        }

        public bool SerializarXml()
        {
            try
            {
                using (XmlTextWriter w = new XmlTextWriter(this.Path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Deposito<T>));

                    ser.Serialize(w, this);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public string DeserializarXml()
        {
            Deposito<T> aux;
            try
            {
                using (XmlTextReader r = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Deposito<T>));

                    aux = (Deposito<T>)ser.Deserialize(r);
                }

            }
            catch (Exception)
            {

                return "";
            }
            return aux.ToString();
        }

    }

}
