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

namespace FrmMenu
{
    public partial class FrmConstruir : Form
    {
        public EtipoMaterial etipoMaterial;
        protected Deposito<Articulo> midepo;
        public Deposito<Articulo> Deposito { get => this.midepo; }

        public FrmConstruir(Deposito<Articulo> midepo)
        {
            InitializeComponent();
            this.midepo = midepo;
            this.MaximizeBox = false;
            CenterToScreen();
        }
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Construir_Click(object sender, EventArgs e)
        {
            Construir();
        }
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            Remover();
        }
        private void comboBoxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfiguracionDefault();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            //richTextBox_Informacion.Text = Convert.ToString(asd.CargarInfoClass(midepo));
            if(listbox_deposito.Items.Count==0)
            {
                MessageBox.Show("No hay datos para guardar");
            }
            else
            {
                GuardadoYCargado asd = new GuardadoYCargado();
                txt_Guardar.Text=
                asd.GuardarInfoClass(midepo);
                MessageBox.Show("Guardado exitoso");
                listbox_deposito.Items.Clear();
            }
        }
/*-------------------------------------------------------- FUNCIONES------------------------------------------------------*/
        public void Limpiar()
        {
            txt_talle.Clear();
            txt_Largo.Clear();
            txt_Color.Clear();
            txt_CodigoSerie.Clear();
            txt_Ancho.Clear();
            comboBox_Tipo.SelectedIndex = -1;
            comboBoxArticulo.SelectedIndex = -1;
        }

        public bool ValidarCamposPantalon()
        {
            bool retorno;
            if (txt_Color.Text is "" || txt_CodigoSerie.Text is "" || txt_Ancho.Text is "" || txt_Largo.Text is "" || comboBox_Tipo.SelectedIndex == -1 || comboBoxArticulo.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos");
                retorno = false;
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }

        public void CrearYAgregarPantalon()
        {
            Pantalones pantalon = new Pantalones(txt_Color.Text, txt_CodigoSerie.Text, etipoMaterial, Convert.ToDouble(txt_Ancho.Text), Convert.ToDouble(txt_Largo.Text));
            StringBuilder stringPantalon = new StringBuilder();

            if (!(midepo.Agregar(pantalon)))
            {
                MessageBox.Show("Ya existe este codigo de producto");
            }
            else
            {
                MessageBox.Show("El pantalon se ha fabricado correctamente");
                Limpiar();
                listbox_deposito.Items.Add(pantalon.ToString());
            }
        }

        public bool ValidarCamposRemeras()
        {
            bool retorno;
            if (txt_Color.Text is "" || txt_CodigoSerie.Text is "" || txt_talle.Text is "" || comboBox_Tipo.SelectedIndex == -1 || comboBoxArticulo.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos");
                retorno = false;
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }
        public void CrearYAgregarRemera()
        {
            Remeras remera = new Remeras(txt_Color.Text, txt_CodigoSerie.Text, etipoMaterial, txt_talle.Text);
            StringBuilder stringRemera = new StringBuilder();

            if (!(midepo.Agregar(remera)))
            {
                MessageBox.Show("Ya existe este codigo de producto");
            }
            else
            {
                MessageBox.Show("La remera se ha fabricado correctamente");
                Limpiar();
                listbox_deposito.Items.Add(remera.ToString());
            }
        }

        public void Remover()
        {
            try
            {
                if (listbox_deposito.Items.Count == 0)
                {
                    MessageBox.Show("No hay nada para remover.");
                }
                else
                {
                    this.midepo.Remover(midepo, midepo.GetIndice(this.listbox_deposito.SelectedIndex));
                    MessageBox.Show("Se ha removido");
                    listbox_deposito.Items.Clear();

                    for (int i = 0; i < this.midepo.Cantidad; i++)
                    {
                        this.listbox_deposito.Items.Add(this.midepo.ListaDeposito[i].ToString());
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ConfiguracionDefault()
        {
            if (this.comboBoxArticulo.SelectedIndex == 1)
            {
                txt_Largo.Enabled = false;
                txt_Ancho.Enabled = false;
                txt_talle.Enabled = true;
            }
            else if (comboBoxArticulo.SelectedIndex == 0)
            {
                txt_Largo.Enabled = true;
                txt_Ancho.Enabled = true;
                txt_talle.Enabled = false;
            }
        }
        public void Construir()
        {
            try
            {
                if (this.comboBoxArticulo.SelectedIndex == 0)
                {
                    if (ValidarCamposPantalon() == true)
                    {
                        CrearYAgregarPantalon();
                    }
                }
                else
                {
                    if (ValidarCamposRemeras() == true)
                    {
                        CrearYAgregarRemera();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
