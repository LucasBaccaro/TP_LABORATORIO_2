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
    public partial class FrmAgregar : Form
    {
        private Deposito depo;
        public Deposito Depo { get => depo; }

        public Etipo tipo;
        public EColores color;
        /// <summary>
        /// Instancio la lista de deposito, con su capacidad
        /// </summary>
        public FrmAgregar()
        {
            InitializeComponent();
            this.depo = new Deposito(2);
            BloquearCampos();
            CenterToScreen();
        }
        /// <summary>
        /// Cierro program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo aceptar, valido si los campos estan vacios, si estan llenos creo pantalon o remera y agrego al deposito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            if (comboBoxArticulo.SelectedIndex == -1 || txt_Talle.Text == "" || txt_CodigoDeBarra.Text == "")
            {
                MessageBox.Show("Complete los campos.");
            }
            else
            {
                if (comboBoxArticulo.SelectedIndex == 0 && depo.EspacioDisponible != depo.Articulos.Count)
                {
                    Pantalon pantalon = new Pantalon(tipo, txt_Talle.Text, txt_CodigoDeBarra.Text);
                    depo += (pantalon);
                    MessageBox.Show("Pantalon creado");
                }
                else if (comboBoxArticulo.SelectedIndex == 1 && depo.EspacioDisponible != depo.Articulos.Count)
                {
                    Remera remera = new Remera(color, txt_Talle.Text, txt_CodigoDeBarra.Text);
                    depo += (remera);
                    MessageBox.Show("Remera creada");
                }
                else
                {
                    MessageBox.Show("Deposito lleno");
                }
                mostrarDatos();
            }
        }
        /// <summary>
        /// Combobox del tipo de pantalon seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBoxTipo.SelectedValue.ToString(), out tipo);
        }
        /// <summary>
        /// Combobox del color de la remera seleccionado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(comboBoxColor.SelectedValue.ToString(), out color);
        }

        /// <summary>
        /// Traigo los datos de los enumerados
        /// </summary>
        private void CargarDatos()
        {
            comboBoxColor.DataSource = Enum.GetValues(typeof(EColores));
            comboBoxTipo.DataSource = Enum.GetValues(typeof(Etipo));
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        /// <summary>
        /// Muestro datos en el listbox
        /// </summary>
        private void mostrarDatos()
        {
            listBox_lista.Items.Clear();
            foreach (Articulo item in depo.Articulos)
            {
                listBox_lista.Items.Add(item.ToString());
            }
        }
        /// <summary>
        /// Quito de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_descoser_Click(object sender, EventArgs e)
        {
            if (listBox_lista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un item");
            }
            else
            {
                depo -= (listBox_lista.SelectedIndex);
                listBox_lista.Items.RemoveAt(listBox_lista.SelectedIndex);
                MessageBox.Show("Material descocido");
            }

        }/// <summary>
         /// Desactivo el combo box del tipo si elije remera, o desactivo el color si elije pantalon
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void comboBoxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArticulo.SelectedIndex == 0)
            {
                comboBoxColor.Enabled = false;
                comboBoxTipo.Enabled = true;
            }
            else
            {
                comboBoxTipo.Enabled = false;
                comboBoxColor.Enabled = true;
            }
        }
        /// <summary>
        /// Desactivo campos al inicio del program
        /// </summary>
        private void BloquearCampos()
        {
            comboBoxColor.Enabled = false;
            comboBoxTipo.Enabled = false;
        }
    }
}
