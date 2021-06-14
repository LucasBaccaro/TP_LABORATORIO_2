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

namespace FrmMenu
{
    public partial class Form1 : Form
    {
        public Deposito<Vaso> miDepositoVasos;
        public Deposito<Cubierto> miDepositoCubiertos;
        public Form1()
        {
            InitializeComponent();
            miDepositoVasos = new Deposito<Vaso>(3);
            miDepositoCubiertos = new Deposito<Cubierto>(3);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Taller_Click(object sender, EventArgs e)
        {
            FrmConstruir frmConstruir = new FrmConstruir(miDepositoVasos, miDepositoCubiertos);
            frmConstruir.ShowDialog();
        }
    }
}
