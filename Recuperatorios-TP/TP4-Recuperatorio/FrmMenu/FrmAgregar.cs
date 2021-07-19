using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmMenu
{
    public partial class FrmAgregar : Form
    {
        private Deposito<Articulo> depo;
        private Pantalon pantalon1;

        public BD baseDatos;
        public Deposito<Articulo> Depo { get => depo; }

        public Etipo tipo;
        public EColores color;
        /// <summary>
        /// Instancio la lista de deposito, con su capacidad
        /// </summary>
        public FrmAgregar()
        {
            InitializeComponent();
            this.depo = new Deposito<Articulo>(2);
            this.baseDatos = new BD();
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
                try
                {
                    if (comboBoxArticulo.SelectedIndex == 0)
                    {
                        Pantalon pantalon = new Pantalon(tipo, txt_Talle.Text, txt_CodigoDeBarra.Text);
                        pantalon1 = pantalon;
                        depo.Evento += EventoPantalon;
                        depo.Agregar(pantalon);
                        MessageBox.Show("Pantalon creado");

                    }
                    else if (comboBoxArticulo.SelectedIndex == 1)
                    {
                        Remera remera = new Remera(color, txt_Talle.Text, txt_CodigoDeBarra.Text);
                        depo.Agregar(remera);
                        MessageBox.Show("Remera creada");
                    }
                }
                catch (NoHayLugarException ex)
                {
                    MessageBox.Show(Extencion.InformarNovedad(ex));
                }
                catch (Exception)
                {
                    MessageBox.Show("Los codigo son iguales");
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
            foreach (Articulo item in depo.ListaDeposito)
            {
                listBox_lista.Items.Add(item);
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

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baseDatos.ObtenerTabla();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (listBox_lista.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una prenda");
            }
            else
            {
                GuardarListaEnDT();
            }
        }
        private void GuardarListaEnDT()
        {
            while (listBox_lista.Items.Count > 0)
            {
                try
                {
                    listBox_lista.SelectedIndex = 0;
                    if (listBox_lista.SelectedItem is Articulo)
                    {
                        if (CargarATable((Articulo)listBox_lista.SelectedItem))
                        {
                            listBox_lista.Items.RemoveAt(listBox_lista.SelectedIndex);

                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private bool CargarATable(Articulo a)
        {
            bool retorno = false;
            if (a is Pantalon)
            {
                dataGridView1.DataSource = baseDatos.AgregarPantalon((Pantalon)a);
                depo.Remover(a);
                retorno = true;
            }
            else if (a is Remera)
            {
                dataGridView1.DataSource = baseDatos.AgregarRemera((Remera)a);
                depo.Remover(a);
                retorno = true;
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            return retorno;
        }

        private void btn_Cierre_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (listBox_lista.SelectedIndex == 0)
                    {
                        MessageBox.Show("Esta por cerrar el dia y le quedan prendas sin cargar");
                    }
                    else
                    {
                        baseDatos.Actualizar();
                        MessageBox.Show("Se ha cerrado y guardado el dia correctamente");
                    }
                }
            }
            catch (IniciarTablaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_serializar_Click(object sender, EventArgs e)
        {
            if (depo.Cantidad == 0)
            {
                MessageBox.Show("No hay prendas en la lista");
            }
            else
            {
                this.depo.SerializarXml();
                MessageBox.Show("Se serializó exitosamente!!!");
            }

        }
        private void btn_Deserializar_Click(object sender, EventArgs e)
        {
            this.richTextBox_serializable.Text = depo.DeserializarXml();
        }
        private void UsarTodo()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => this.btn_cargar_Click(null, null)));
                    Invoke(new Action(() => this.btn_Guardar_Click(null, null)));
                    Invoke(new Action(() => this.btn_Cierre_Click(null, null)));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void btn_hilos_Click_1(object sender, EventArgs e)
        {

            if (listBox_lista.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor cree una prenda");
            }
            else
            {
                Thread hilo = new Thread(this.UsarTodo);
                hilo.Start();
            }
        }

        private void EventoPantalon(object sender, EventArgs e)
        {
            bool todoOK = Ticketera.ImprimirFactura(pantalon1);

            if (todoOK)
            {
                MessageBox.Show("Factura impresa correctamente!!!");
                depo.Remover(pantalon1);
            }
            else
            {
                MessageBox.Show("No se pudo imprimir la factura!!!");
            }
        }


    }
}

