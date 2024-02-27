using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Proyecto2Ev_DI_NC.Clases
{
    public class Producto
    {
        private int id;
        private int stock;
        private double precio;

        public Producto(int id, int stock, double precio)
        {
            this.id = id;
            this.stock = stock;
            this.precio = precio;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Stock 
        {  
            get { return stock; } 
            set {  stock = value; } 
        }
        public double Precio 
        { 
            get {  return precio; } 
            set {  precio = value; } 
        }
    }
}
