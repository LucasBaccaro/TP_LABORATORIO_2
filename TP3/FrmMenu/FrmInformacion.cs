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
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Diagnostics;

namespace FrmMenu
{
    public partial class FrmInformacion : Form
    {
        protected Deposito<Articulo> midepo;
        public Deposito<Articulo> Deposito { get => this.midepo; }
        public FrmInformacion(Deposito<Articulo> midepo)
        {
            this.midepo = midepo;
            InitializeComponent();
            this.MaximizeBox = false;
            CenterToScreen();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
            }
            GuardadoYCargado asd = new GuardadoYCargado();
            //richTextBox_Informacion.Clear();
            richTextBox_Informacion.Text = asd.CargarInfoClass(midepo).ToString();
        }
    }

}
