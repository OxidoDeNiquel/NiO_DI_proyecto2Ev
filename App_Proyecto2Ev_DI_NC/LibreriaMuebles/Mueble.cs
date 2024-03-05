using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMuebles
{
    public class Mueble : Producto
    {
        private string name;
        private string type;
        private string establishment;
        private Boolean exhibition;
        private String storeSection;

        public Mueble(int id, int stock, double price, string name, string type, string establishment, bool exhibition, string storeSection)
            : base(id, stock, price)
        {
            this.name = name;
            this.type = type;
            this.establishment = establishment;
            this.exhibition = exhibition;
            this.storeSection = storeSection;
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

        public string Establishment
        {
            get { return establishment; }
            set { establishment = value; }
        }

        public bool Exhibition
        {
            get { return exhibition; }
            set { exhibition = value; }
        }

        public string StoreSection
        {
            get { return storeSection; }
            set { storeSection = value; }
        }
    }
}
