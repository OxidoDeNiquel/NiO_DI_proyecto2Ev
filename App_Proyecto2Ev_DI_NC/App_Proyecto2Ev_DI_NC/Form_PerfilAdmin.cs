using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proyecto2Ev_DI_NC
{
    public partial class Form_PerfilAdmin : Form
    {
        public Form_PerfilAdmin()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form_LogIn form_LogIn = new Form_LogIn();
            form_LogIn.Show();
            this.Visible = false;

            MessageBox.Show("Se ha cerrado la sesión con éxito");
        }
    }
}
