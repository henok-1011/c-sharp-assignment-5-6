using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Product
    {
        static List <Product> products = new List <Product> ();    
        public int ProductID { get; set; }
        public string Date { get; set; }
        public string InvetoryNumber { get; set; }

        public string ObjectName { get; set; }

        public int price { get; set; }
        public int count { get; set; }
        public bool isAvailable { get; set; }

 
        public void save()
        {
            products.Add(this);
            MessageBox.Show("object saved");
        }

        static public List <Product> GetAllProducts()
        {
            return products;
        }


    }
}
