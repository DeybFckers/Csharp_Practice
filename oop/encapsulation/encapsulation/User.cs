using System;

namespace encapsulation
{
    class User
    {
        //private attributes
        private int userID;
        private String userName;
        private String firstName, lastName;

        //properties
        public int UserID
        {
            get { return userID; }
            //if you want to readonly just remove the set
            set { 
                if(value >= 1000)
                {
                    userID = value;
                }
                else
                {
                    Console.WriteLine("Error User ID must not be below 1000");
                }
                
            }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        //you can get a multiple get variable
        public String FullName
        {
            get { return firstName + " " + lastName;  }
            set
            {
                firstName = value;
                lastName = value;
            }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //constructor
        public User(int userID, string userName, string firstName, string lastName)
        {
            UserID = userID;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
          
        }
    }
}