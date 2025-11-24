using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            Person p1 = new Person();
            p1.firstName = "David";
            p1.lastName = "SDPT";
            p1.age = 21;
            p1.sex = 'M';

            Person p2 = new Person();
            p2.firstName = "Alenere";
            p2.lastName = "SDPT";
            p2.age = 21;
            p2.sex = 'F';

            Console.WriteLine(p1.firstName + " " + p1.lastName );
            Console.WriteLine(p2.firstName + " " + p2.lastName );

            //using static class
            Product.productName = "Milk";
            Product.productDescription = "Bear brand";
            Product.productPrice = 15;
            Product.productQty = 5;

            Console.WriteLine(Product.productName + " " + Product.productDescription );
            
        }
    }
}