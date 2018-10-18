using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace frmReseñaAnalisis
{
    public partial class frmRseñaAnalisis : Form
    {
        // Definimos la  conexión a la base de datos.
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                                integrated security = true; database = AdventureWorks2014");

        public frmRseñaAnalisis()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra el formulario principal de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("¿Está seguro que desea salir?", "Control de reseñas", MessageBoxButtons.YesNoCancel);

            // verificamos si el usuario respondio si.
            if (s == DialogResult.Yes)
            {
                // Cerramos la aplicación.
                this.Close();
            }
        }

        /// <summary>
        /// Se encarga de cargar todos los datos a la lista de productos e inicializar valores
        /// iniciales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRseñaAnalisis_Load(object sender, EventArgs e)
        {
            // defnimos el query de consulta.
            string sql = "SELECT Name FROM Production.Product WHERE FinishedGoodsFlag = 1;";

            // creamos el comando
            SqlCommand com = new SqlCommand(sql, conn);

            try
            {
                // establecemos conexion
                conn.Open();

                // Ejecutamos el query via un DataReader y llenamos el listbox
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    lstProductos.Items.Add(rdr[0]);
                }


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepcion");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Definimos el comando
            SqlCommand cmd = new SqlCommand("sp_InsertarResenia",conn);

            // Definimos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Verificcamos que el usaurio haya ingresado todos los valores.
            if (lstProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccinar un producto de la lista", "Error en ingreso", MessageBoxButtons.OK);

            }
            else if(txtNombre.Text == "" || txtCorreo.Text=="" || lstValor.SelectedIndex == -1 )
            {
                MessageBox.Show("Debe ingresar el nombre, el correo y la valoración para registrar la reseña", "Error en ingreso", MessageBoxButtons.OK);

            }
            else
            {
                try
                {
                    // definimos los parámetros necesarios para el storeProcedure.
                    cmd.Parameters.Add(new SqlParameter("@NombreCodigo", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@NombreCodigo"].Value =lstProductos.SelectedItems[0].ToString();

                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Nombre"].Value = txtNombre.Text;

                    cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Correo"].Value = txtCorreo.Text;

                    cmd.Parameters.Add(new SqlParameter("@Valor", SqlDbType.Int, 50));
                    cmd.Parameters["@Valor"].Value = lstValor.SelectedItems[0];

                    cmd.Parameters.Add(new SqlParameter("@Comentarios", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Comentarios"].Value = txtComentarios.Text;

                    cmd.Parameters.Add(new SqlParameter("@FechaModifica", SqlDbType.DateTime));
                    cmd.Parameters["@FechaModifica"].Value = System.DateTime.Now;

                    cmd.Parameters.Add(new SqlParameter("@FechaCrea", SqlDbType.DateTime));
                    cmd.Parameters["@FechaCrea"].Value = System.DateTime.Now;

                    // Abrimos la conexión
                    conn.Open();

                    // Ejecutamos el comando
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reseña registrado correctamente", "Control de reseñas", MessageBoxButtons.OK);

                    // limpiamos las cajas de texto 
                    txtNombre.Text = "";
                    txtCorreo.Text = "";
                    txtComentarios.Text = "";
                    lstProductos.SelectedItems.Clear();
                    lstValor.SelectedItems.Clear();
                    txtNombre.Focus();




                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepción");
                }
                finally
                {
                    conn.Close();
                }
            }
           
        }
    }
}
