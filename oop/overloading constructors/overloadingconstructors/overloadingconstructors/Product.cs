using System;
using System.Collections.Generic;
using System.Text;

namespace overloadingconstructors
{
    internal class Product
    {
        //Overloading Constructors are good for optional or null value
        public int productID {  get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public int productStock { get; set; }
        public float productPrice { get; set; }

        
        public Product(int productID, string productName, string productDescription, int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDescription = productDescription;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }

        //you can redeclare the classname of constructor as long as the constructor are not same

        public Product(int productID, string productName,  int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }

        public Product()
        {

        }
    }
}
