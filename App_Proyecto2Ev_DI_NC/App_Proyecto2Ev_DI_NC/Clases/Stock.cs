using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    internal class Stock
    {
        private int id;
        private int exhibitionStock;
        private int storeStock;

        public Stock(int id, int exhibitionStock, int storeStock)
        {
            this.id = id;
            this.exhibitionStock = exhibitionStock;
            this.storeStock = storeStock;
        }

    }
}
