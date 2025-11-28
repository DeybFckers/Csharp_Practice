using System;

namespace overloadingconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //without description
            Product p = new Product(1, "Milky",5,150);
            //with description constructors
            Product p1 = new Product(2, "MIlky", "Description", 5, 150);
            //no constructor
            /*the reason why didn't require the construtor because of the 
             * public product() no constructor*/
            Product p2 = new Product();

            /*you can pass the constructor without putting a parameters
            because of p2*/
            p2.productID = 1;
            p2.productName = "Milo";

            
            Console.WriteLine(p2.productID + p2.productName);
        }
    }
}