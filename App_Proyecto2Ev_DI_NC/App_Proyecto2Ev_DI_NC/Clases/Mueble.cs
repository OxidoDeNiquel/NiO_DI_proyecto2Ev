using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    public class Mueble
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

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Establishment
        {
            get { return establishment; }
            set { establishment = value; }
        }

        public bool Exhibition
        {
            get { return exhibition; }
            set { exhibition = value; }
        }

        public bool Store
        {
            get { return store; }
            set { store = value; }
        }

        public string StoreSection
        {
            get { return storeSection; }
            set { storeSection = value; }
        }


    }
}
