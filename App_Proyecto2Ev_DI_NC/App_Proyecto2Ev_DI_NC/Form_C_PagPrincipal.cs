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
    }
}
