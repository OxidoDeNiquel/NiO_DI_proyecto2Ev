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
    public partial class Form_C_PagPrincipal : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_C_PagPrincipal()
        {
            InitializeComponent();
            loadData();
            dataGridView_muebles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void loadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio FROM Muebles";

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

        private void button_fbano_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio FROM Muebles WHERE Tipo = 'Baño'";

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

        private void button_fcocina_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio FROM Muebles WHERE Tipo = 'Cocina'";

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

        private void button_fdorm_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio FROM Muebles WHERE Tipo = 'Dormitorio'";

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

        private void button_fsde_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio FROM Muebles WHERE Tipo = 'Sala de estar'";

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

        private void button_fsalon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio " +
                                            "FROM Muebles " +
                                            "WHERE Tipo = 'Salón'";

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

        private void button_bcn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio " +
                                            "FROM Muebles " +
                                            "WHERE Establecimiento = 'Barcelona'";

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

        private void button_mad_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio " +
                                            "FROM Muebles " +
                                            "WHERE Establecimiento = 'Madrid'";

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

        private void button_zgz_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los muebles
                    string selectQuery = "SELECT Nombre, Tipo, Establecimiento, Exposicion AS [Exposición], Seccion_almacen AS [Sección Almacen], Stock, Precio " +
                                            "FROM Muebles " +
                                            "WHERE Establecimiento = 'Zaragoza'";

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

        private void pictureBox_perfil_Click(object sender, EventArgs e)
        {
            Form_PerfilCliente form_PerfilCliente = new Form_PerfilCliente();
            form_PerfilCliente.Show();
            this.Visible = false;
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Los botones superiores filtrarán por tipo de mueble.\n\n" +
                "- Los botones situados en la columna izquierda filtrarán por ciudad donde se encuentren los muebles.\n\n" +
                "Si deseas cerrar sesión, presione en el icono de perfil situado arriba a la derecha y seleccione 'Cerrar sesión'.",
                "Ayuda Cliente",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }
    }
}
