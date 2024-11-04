using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230062
{ 
    internal abstract class Product_714230062
    {
        private string myType;
        private string myTitle;

        public Product_714230062()
        {

        }
        // Constructor
        public Product_714230062(string myType, string myTitle)
        {
            this.myType = myType;
            this.myTitle = myTitle;
        }

        // Properti untuk MyType
        public string MyType 
        {
            get { return myType; }
            set { myType = value; }
        }

        // Properti untuk MyTitle
        public string MyTitle 
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        // Metode abstrak untuk menampilkan informasi produk
        public abstract void DisplayInfo();
    }
}
