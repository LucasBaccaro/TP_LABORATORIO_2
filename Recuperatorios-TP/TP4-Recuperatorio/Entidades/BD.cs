using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BD
    {
        private DataTable dt;
        private SqlConnection conexion;
        private SqlDataAdapter da;

        #region Constructor
        /// <summary>
        /// Constructor, instancia un AccesoDatos,asigna la conexion
        /// </summary>
        public BD()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Crea el DataTable
        /// </summary>
        /// <returns>Retorna el DataTable</returns>
        public DataTable CrearDataTable()
        {
            try
            {
                this.dt = new DataTable("depositoArticulos");
                this.dt.Columns.Add("id", typeof(int));
                this.dt.Columns.Add("producto", typeof(string));
                this.dt.Columns.Add("talle", typeof(string));
                this.dt.Columns.Add("codigo", typeof(string));
                this.dt.Columns.Add("color", typeof(string));
                this.dt.Columns.Add("tipo", typeof(string));


                this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };
                this.dt.Columns["id"].AutoIncrement = true;
                this.dt.Columns["id"].AutoIncrementSeed = 1;
                this.dt.Columns["id"].AutoIncrementStep = 1;

            }
            catch (Exception)
            {
            }

            return dt;
        }
        /// <summary>
        /// Configura el dataAdapter
        /// </summary>
        /// <returns>Retorna el DataAdapter</returns>
        public SqlDataAdapter ConfigurarDataAdapter()
        {
            this.da = new SqlDataAdapter();

            try
            {
                this.da.SelectCommand = new SqlCommand("SELECT * FROM depositoArticulos", this.conexion);
                this.da.InsertCommand = new SqlCommand("INSERT INTO depositoArticulos (producto,talle,codigo,color,tipo) VALUES (@producto, @talle, @codigo, @color, @tipo)", this.conexion);
                this.da.UpdateCommand = new SqlCommand("UPDATE depositoArticulos SET producto=@producto, talle=@talle, codigo=@codigo, color=@color,tipo=@tipo WHERE id=@id", this.conexion);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM depositoArticulos WHERE id=@id", this.conexion);

                this.da.InsertCommand.Parameters.Add("@producto", SqlDbType.VarChar, 50, "producto");
                this.da.InsertCommand.Parameters.Add("@talle", SqlDbType.VarChar, 50, "talle");
                this.da.InsertCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 50, "codigo");
                this.da.InsertCommand.Parameters.Add("@color", SqlDbType.VarChar, 50, "color");
                this.da.InsertCommand.Parameters.Add("@tipo", SqlDbType.VarChar, 50, "tipo");


                this.da.UpdateCommand.Parameters.Add("@producto", SqlDbType.VarChar, 50, "producto");
                this.da.UpdateCommand.Parameters.Add("@talle", SqlDbType.VarChar, 50, "talle");
                this.da.UpdateCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 50, "codigo");
                this.da.UpdateCommand.Parameters.Add("@color", SqlDbType.VarChar, 50, "color");
                this.da.UpdateCommand.Parameters.Add("@tipo", SqlDbType.VarChar, 50, "tipo");

                this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");
            }
            catch (Exception)
            {
            }

            return da;
        }

        /// <summary>
        /// Utiliza los emtodos crearDataTable y configurarDataAdapter para obtener la tabla de libros de la BD
        /// </summary>
        /// <returns>Retorna el DataTable</returns>
        public DataTable ObtenerTabla()
        {
            DataTable tabla = this.CrearDataTable();
            this.da = this.ConfigurarDataAdapter();

            try
            {
                this.da.Fill(tabla);

            }
            catch (Exception)
            {
            }

            return tabla;
        }

        /// <summary>
        /// Actualiza la BD con los cambios realizados en el dataTable
        /// </summary>
        public void Actualizar()
        {
            
                if(da != null)
                {
                    this.da.Update(dt);
                }
                else
                {
                    throw new IniciarTablaException();
                }
        }
        public DataTable AgregarPantalon(Pantalon p)
        {
            try
            {
                if(dt != null)
                {
                    DataRow filaPantalon = this.dt.NewRow();

                    DataColumnCollection dataColumn = this.dt.Columns;

                    filaPantalon[dataColumn["producto"]] = "Pantalon";
                    filaPantalon[dataColumn["talle"]] = p.Talle;
                    filaPantalon[dataColumn["codigo"]] = p.CodigoDeBarra;
                   // filaPantalon[dataColumn["color"]] = DBNull.Value;
                    filaPantalon[dataColumn["tipo"]] = p.Tipo;

                    this.dt.Rows.Add(filaPantalon);
                }
                else
                {
                    throw new IniciarTablaException();
                }
               
            }
            catch (Exception)
            {
            }
            return this.dt;
        }

        public DataTable AgregarRemera(Remera r)
        {
            try
            {
                DataRow filaRemera = this.dt.NewRow();

                DataColumnCollection dataColumn = this.dt.Columns;

                filaRemera[dataColumn["producto"]] = "Remera";
                filaRemera[dataColumn["talle"]] = r.Talle;
                filaRemera[dataColumn["codigo"]] = r.CodigoDeBarra;
                filaRemera[dataColumn["color"]] = r.Color;
               // filaRemera[dataColumn["tipo"]] = DBNull.Value;

                this.dt.Rows.Add(filaRemera);
            }
            catch (Exception)
            {
            }
            return this.dt;
        }
        #endregion
    }
}

