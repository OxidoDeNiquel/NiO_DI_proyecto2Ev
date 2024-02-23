using App_Proyecto2Ev_DI_NC.Clases;
using LogIn;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App_Proyecto2Ev_DI_NC
{
    public partial class Form_LogIn : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_LogIn()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text.Length < 1 || textBox_password.Text.Length < 1)
            {
                MessageBox.Show("Username o Password no válido, es muy corto");
            }
            else
            {
                try
                {
                    string usernameToSearch = textBox_username.Text;
                    string sqlQuery = "SELECT * FROM Clientes WHERE Usuario LIKE @Username;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Username", usernameToSearch);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Cliente result = new Cliente
                                    (
                                        Convert.ToInt32(reader["Id_Cliente"]),
                                        reader["Nombre"].ToString(),
                                        reader["Apellido1"].ToString(),
                                        reader["Apellido2"].ToString(),
                                        Convert.ToInt32(reader["CodPostal"]),
                                        reader["Usuario"].ToString(),
                                        AesCrypt.Decrypt( reader["Contraseña"].ToString())
                                    );

                                    if(result.Password.Equals(textBox_password.Text))
                                    {
                                        Form_C_PagPrincipal pagPrincipal = new Form_C_PagPrincipal();
                                        pagPrincipal.Show();
                                        this.Visible = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Contraseña incorrecta, intentelo de nuevo");
                                    }

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    MessageBox.Show("El usuario no existe");
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_SignIn signin = new Form_SignIn();
            signin.ShowDialog();
        }
    }
}