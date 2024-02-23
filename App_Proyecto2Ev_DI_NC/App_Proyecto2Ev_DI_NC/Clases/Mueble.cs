using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    internal class Mueble
    {
        private int id;
        private string name;
        private string type;
        private int establishment;
        private Boolean exhibition;
        private Boolean store;
        private String storeSection;

        public Mueble(int id, string name, string type, int establishment, bool exhibition, bool store, string storeSection)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.establishment = establishment;
            this.exhibition = exhibition;
            this.store = store;
            this.storeSection = storeSection;
        }


    }
}
