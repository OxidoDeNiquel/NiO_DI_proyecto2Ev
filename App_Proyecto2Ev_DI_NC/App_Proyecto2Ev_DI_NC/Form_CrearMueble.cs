using LogIn;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
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
    public partial class Form_CrearMueble : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_CrearMueble()
        {
            InitializeComponent();
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para la inserción
                    string insertQuery = "INSERT INTO Muebles (Nombre, Tipo, Establecimiento, Exposicion, Seccion_Almacen, Stock) " +
                        "VALUES (@Nombre, @Tipo, @Establecimiento, @Exposicion, @Seccion_Almacen, @Stock)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Utilizando Parameters.AddWithValue para evitar SQL injection
                        cmd.Parameters.AddWithValue("@Nombre", textBox_nombre.Text);
                        cmd.Parameters.AddWithValue("@Tipo", comboBox_tipo.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Establecimiento", comboBox_establecimiento.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Exposicion", checkBox_expo.Checked);
                        cmd.Parameters.AddWithValue("@Seccion_Almacen", textBox_s_almacen.Text);
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(textBox_stock.Text));

                        // Ejecutar la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show($"{rowsAffected} fila(s) insertada(s).");
                    }
                }

                MessageBox.Show("Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Form_PagAdmin form_PagAdmin = new Form_PagAdmin();
            form_PagAdmin.Show();
            this.Visible = false;
        }
    }
}
