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
            dataGridView_muebles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                    string selectQuery = "SELECT Id_Mueble, Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio FROM Muebles";

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

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView_muebles.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView_muebles.SelectedRows[0];

                // Obtener los valores de las celdas necesarias
                int id = Convert.ToInt32(selectedRow.Cells["Id_Mueble"].Value);
                int stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
                double precio = Convert.ToDouble(selectedRow.Cells["Precio"].Value);
                string name = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                string type = Convert.ToString(selectedRow.Cells["Tipo"].Value);
                string establishment = Convert.ToString(selectedRow.Cells["Establecimiento"].Value);
                bool exhibition = Convert.ToBoolean(selectedRow.Cells["Exposición"].Value);
                string storeSection = Convert.ToString(selectedRow.Cells["Sección Almacen"].Value);

                // Crear e instanciar el formulario de actualización
                Form_ActualizarMueble actualizarMuebleForm = new Form_ActualizarMueble(id, stock, precio, name, type, establishment, exhibition, storeSection);

                // Mostrar el formulario de actualización
                actualizarMuebleForm.ShowDialog();
            }
        }

        private void dataGridView_muebles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar el evento CellClick para capturar la fila seleccionada
            if (e.RowIndex >= 0)
            {
                dataGridView_muebles.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_muebles.SelectedRows.Count > 0)
            {
                // Obtener el identificador único del registro a eliminar
                int id = Convert.ToInt32(dataGridView_muebles.SelectedRows[0].Cells["Id_Mueble"].Value);

                // Eliminar la fila del DataGridView
                dataGridView_muebles.Rows.Remove(dataGridView_muebles.SelectedRows[0]);

                // Llamar a un método que elimine el registro de la base de datos
                EliminarRegistroEnBaseDeDatos(id);
            }
        }
        private void EliminarRegistroEnBaseDeDatos(int id)
        {
            // Supongamos que "conexion" es tu objeto SqlConnection y está correctamente configurado.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Crear la consulta de eliminación
                string query = "DELETE FROM Muebles WHERE Id_Mueble = @Id";

                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@Id", id);

                    // Abrir la conexión y ejecutar la consulta
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
