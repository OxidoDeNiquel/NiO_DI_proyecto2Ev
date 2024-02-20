using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    internal class Cliente
    {
        private String nombre;
        private String apellido1;
        private String apellido2;
        private int codPostal;
        private int id;
        private int userId;

        public Cliente(string nombre, string apellido1, string apellido2, int codPostal, int id, int userId)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.codPostal = codPostal;
            this.id = id;
            this.userId = userId;
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

        public int getUserId()
        {
            return userId;
        }
        //setter nombre, apellido1, apellido2, codpostal

        public void setUserId(int userId)
        {
            this.userId = userId;
        }


    }
}
