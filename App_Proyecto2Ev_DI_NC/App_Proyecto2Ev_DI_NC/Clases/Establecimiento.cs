using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    public class Establecimiento
    {
        private int id;
        private String name;
        private String description;
        private int postalCode;
        private String city;
        private String country;

        public Establecimiento(int id, string name, string description, int postalCode, string city, string country)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
