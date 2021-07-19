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
        
        public FrmMenu()
        {
            InitializeComponent();
            CenterToScreen();
        }
        /// <summary>
        /// Abro formulario Agregar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmAgregar frmAgregar = new FrmAgregar();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// Cierre del program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
