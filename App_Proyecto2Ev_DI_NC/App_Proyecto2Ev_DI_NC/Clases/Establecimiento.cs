using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    internal class Establecimiento
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

        public int getId() { return id; }
        public String getName() { return name; }
        public String getDescription() { return description; }
        public int getPostalCode() {  return postalCode; }
        public String getCity() { return city; }
        public String getCountry() { return country; }
    }
}
