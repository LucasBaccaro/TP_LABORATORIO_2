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
    public partial class FrmMenu : Form
    {
        public Deposito<Articulo> depoTodos;
        public Deposito<Articulo> depoTodos2;

        public FrmMenu()
        {
            InitializeComponent();
            CenterToScreen();
            this.MaximizeBox = false;
            this.depoTodos = new Deposito<Articulo>(100);
            //this.depoTodos2 = new Deposito<Articulo>(100);
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Taller_Click(object sender, EventArgs e)
        {
            FrmConstruir frmConstruir = new FrmConstruir(depoTodos);
            frmConstruir.ShowDialog();
        }

        private void button_Informacion_Click(object sender, EventArgs e)
        {
            FrmInformacion frmConstruir = new FrmInformacion(depoTodos);
            frmConstruir.ShowDialog();

        }
    }
}
