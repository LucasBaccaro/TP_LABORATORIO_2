using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmboOperador.Text = "+";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == string.Empty || txtNum2.Text == string.Empty)
            {
                MessageBox.Show("Para convertir a binario, ingrese numeros.");
            }
            {
                Numero num = new Numero();
                lblResultado.Text = num.DecimalBinario(lblResultado.Text);
            }
          

        }
        private void convertirADecimal_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == string.Empty || txtNum2.Text == string.Empty)
            {
                MessageBox.Show("Para convertir a decimal, ingrese numeros.");
            }
            else
            {
                Numero num = new Numero();
                lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
            }
               
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(txtNum1.Text == string.Empty || txtNum2.Text == string.Empty)
            {
                MessageBox.Show("Ingrese numeros para operar");
            }else
            {
            string operacion;
            operacion = Convert.ToString(Operar(txtNum1.Text, txtNum2.Text, cmboOperador.Text));
            lblResultado.Text = operacion;
            }
            
        }
        private void Limpiar()
        {
            this.txtNum1.Clear();
            this.txtNum2.Clear();
            this.lblResultado.Text = null;

        }
        private static double Operar (string numero1,string numero2,string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            if (operador=="")
            {
                operador = "+";
            }
            double resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }  
    }
}
