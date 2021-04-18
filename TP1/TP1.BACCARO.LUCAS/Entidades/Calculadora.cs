using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// funcion operar,recibe 2 clases Num y operador
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado = 0;

            operador = ValidarOperador(Convert.ToChar(operador));

            switch (operador)
            {  
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// metodo validar operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador.ToString();
            }
            else
            {
                operador = '+';
                return operador.ToString();
            }
            
        }

    }
    
}
