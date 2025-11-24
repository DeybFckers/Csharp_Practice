using System;
using System.Collections.Generic;
using System.Text;

namespace encapsulation
{
    internal class person
    {
        // automatic properties instead of declaring global variable 
        /* the cons of automatic properties is you can't readonly 
         * or remove the set and you can't put a validator but you can get */
        
        public int personID
        {
            get; set;
        }
        public String personName 
        { 
            get; set; 
        }

        //constructor
        public person(int personID, String personName)
        {
            this.personID = personID;
            this.personName = personName;
        }

    }
}
