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
using System.Windows.Forms.VisualStyles;

namespace App_Proyecto2Ev_DI_NC
{
    public partial class Form_ActualizarMueble : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        private int Id;
        public Form_ActualizarMueble(int id, int stock, double precio, string name, string type, string establishment, Boolean exhibition, string storeSection)
        {
            InitializeComponent();
            // Asignar valores a los controles del formulario
            this.Id = id;
            textBox_nombre.Text = name;
            textBox_precio.Text = precio.ToString();
            textBox_stock.Text = stock.ToString();
            comboBox_tipo.Text = type;  // Utiliza la propiedad Text para establecer el valor seleccionado
            comboBox_establecimiento.Text = establishment;  // Utiliza la propiedad Text para establecer el valor seleccionado
            checkBox_expo.Checked = exhibition;
            textBox_s_almacen.Text = storeSection;
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "UPDATE Muebles SET Nombre = @Nombre, Tipo = @Tipo, Establecimiento = @Establecimiento, Exposicion = @Exposicion, Seccion_Almacen = @Seccion_Almacen, Stock = @Stock, Precio = @Precio " +
                                                        "WHERE Id_Mueble = @Id";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Utilizando Parameters.AddWithValue para evitar SQL injection
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Nombre", textBox_nombre.Text);
                        cmd.Parameters.AddWithValue("@Tipo", comboBox_tipo.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Establecimiento", comboBox_establecimiento.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Exposicion", checkBox_expo.Checked);
                        cmd.Parameters.AddWithValue("@Seccion_Almacen", textBox_s_almacen.Text);
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(textBox_stock.Text));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDouble(textBox_precio.Text));

                        // Ejecutar la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show($"{rowsAffected} fila(s) actualizada(s).");
                    }
                }

                Form_PagAdmin pagAdmin = new Form_PagAdmin();
                pagAdmin.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Form_PagAdmin pagAdmin = new Form_PagAdmin();
            pagAdmin.Show();
            this.Visible = false;
        }
    }
}
