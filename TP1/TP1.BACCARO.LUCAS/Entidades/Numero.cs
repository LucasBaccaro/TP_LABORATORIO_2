using System;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Setear en 0 el numero
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// asignar la variable double de num 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// num variable string
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// setter num
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        /// <summary>
        /// funcion validar
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {

            if (!double.TryParse(strNumero, out double numeroAux))
            {
                numeroAux = 0;
            }
            return numeroAux;
        }
        /// <summary>
        /// sobrecargar +
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }
        /// <summary>
        /// sobrecargar -
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }
        /// <summary>
        /// sobrecargar *
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }
        /// <summary>
        /// sobrecargar / y que si se divida por 0 de el min value
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if (n1.numero == 0 || n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }
        /// <summary>
        /// metodo binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {

            if (!EsBinario(binario))
            {
                return "Valor invalido";
            }
            else
            {
                return Convert.ToString(Convert.ToInt32(binario, 2), 10);
            }
        }
        /// <summary>
        /// metodo decimal a binario double
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {

            if (numero < 0)
            {
                return "Valor invalido";
            }
            else
            {
                string casteo = Math.Abs(numero).ToString();

                return Convert.ToString(Convert.ToInt32(casteo), 2);
            }

        }
        /// <summary>
        /// metido decimal binario string
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>

        public string DecimalBinario(string numero)
        {
            bool esNumero;
            string retorno = "";

            esNumero = int.TryParse(numero.ToString(), out int auxNumero);

            if (esNumero)
            {
                if (auxNumero > 0)
                {
                    int aux;
                    string auxString;

                    while (auxNumero > 0)
                    {
                        aux = auxNumero % 2;
                        auxString = Convert.ToString(aux);
                        retorno = auxString + retorno;
                        auxNumero /= 2;
                    }
                    return retorno;
                }
                else
                {
                    retorno = "0";
                }
            }
            else
            {
                retorno = "Valor invalido";
            }

            return retorno;
        }
        /// <summary>
        /// Metodo es binario o no
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        
        private bool EsBinario(string binario)
        {
            bool retorno = false;

            foreach (char caracter in binario)
            {
                if (caracter == '0' || caracter == '1')
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
    }
}


    
   