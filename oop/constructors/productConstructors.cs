using System;

namespace constructors
{
    class ProductConstructors
    {
        public string name;
        public float price;

        public ProductConstructors(string name, float aPrice)
        {
            /*if you want to refer in the global variable or constructor
            and same name with the parameteres, you can use this.[variable] so avoid conflict
            and if you dont want to use then the parameters should be unique*/
            
                //constructors with this
            this.name = name;
                       //parameters
            //contructors without using this
            price = aPrice;
                    //parameters unique name
        }               
    }
}