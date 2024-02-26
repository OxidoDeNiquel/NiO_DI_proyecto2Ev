using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proyecto2Ev_DI_NC
{
    public partial class Form_PagAdmin : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_PagAdmin()
        {
            InitializeComponent();
            loadData();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Form_CrearMueble form_CrearMueble = new Form_CrearMueble();
            form_CrearMueble.Show();
            this.Visible = false;
        }

        private void pictureBox_perfil_Click(object sender, EventArgs e)
        {
            Form_PerfilAdmin form_PerfilAdmin = new Form_PerfilAdmin();
            form_PerfilAdmin.Show();
            this.Visible = false;
        }

        private void loadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock FROM Muebles";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        // Utilizar un SqlDataAdapter para llenar un DataTable con los resultados
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Mostrar los resultados en el DataGridView
                            dataGridView_muebles.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                throw;
            }
        }


        /*
         *  private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // Manejar el evento CellClick para capturar la fila seleccionada
                if (e.RowIndex >= 0)
                {
                    dataGridView.Rows[e.RowIndex].Selected = true;
                }
            }

            private void BtnEliminar_Click(object sender, EventArgs e)
            {
                // Al hacer clic en el botón Eliminar, eliminar la fila seleccionada
                if (dataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el índice de la fila seleccionada
                    int selectedIndex = dataGridView.SelectedRows[0].Index;

                    // Eliminar la fila del DataTable
                    dataTable.Rows.RemoveAt(selectedIndex);

                    // Actualizar el DataGridView
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = dataTable;
                }
            }
        */
    }
}
