using LogIn;
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
    public partial class Form_SignIn : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_SignIn()
        {
            InitializeComponent();
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("SaveClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                //Encriptar la contraseña
                string encpss = AesCrypt.Encrypt(textBox_password.Text);

                // Asegúrate de que los nombres de los parámetros coincidan con los del procedimiento almacenado
                cmd.Parameters.AddWithValue("@username", textBox_username.Text);
                cmd.Parameters.AddWithValue("@password", encpss);
                cmd.Parameters.AddWithValue("@nombre", textBox_nombre.Text);
                cmd.Parameters.AddWithValue("@apellido1", textBox_apellido1.Text);
                cmd.Parameters.AddWithValue("@apellido2", textBox_apellido2.Text);
                cmd.Parameters.AddWithValue("@codpostal", textBox_codpostal.Text);

                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
