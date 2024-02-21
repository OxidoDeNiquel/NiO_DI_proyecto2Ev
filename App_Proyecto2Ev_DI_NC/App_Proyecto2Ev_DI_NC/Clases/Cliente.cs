using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    internal class Cliente
    {
        private int id;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private int codPostal;
        private String username;
        private String password;

        public Cliente(string nombre, string apellido1, string apellido2, int codPostal, int id, String username, string password)
        {

            this.id = id;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.codPostal = codPostal;
            this.username = username;
            this.password = password;
        }

        //GETTERS Y SETTERS
        public String getNombre()
        {
            return nombre;
        }

        public String getApellido1()
        {
            return apellido1;
        }

        public String getApellido2()
        {
            return apellido2;
        }

        public int getCodPostal()
        {
            return codPostal;
        }

        public int getId()
        {
            return id;
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

        public void setNombre(String nombre) 
        { 
            this.nombre = nombre;
        }

        public void setApellido1(String apellido1)
        {
            this.apellido1 = apellido1;
        }

        public void setApellido2(String apellido2)
        {
            this.apellido2 = apellido2;
        }

        public void setCodPostal(int codPostal)
        {
            this.codPostal = codPostal;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }
    }
}
