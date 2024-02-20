using LogIn;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
            //logica de inicio de sesion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_SignIn signin = new Form_SignIn();
            signin.ShowDialog();
        }
    }
}