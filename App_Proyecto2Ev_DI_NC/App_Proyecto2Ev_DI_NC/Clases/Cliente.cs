using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    public class Cliente
    {
        private int id;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private int codPostal;
        private String username;
        private String password;

        public Cliente(int id, string nombre, string apellido1, string apellido2, int codPostal, String username, string password)
        {

            this.id = id;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.codPostal = codPostal;
            this.username = username;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public int CodPostal { get => codPostal; set => codPostal = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
