using System;

namespace objectmethods
{
    class Students
    {
        public string firstName, lastName, course, section;
        public float year, midtermGrade, finalGrade;

        public Students(String firstName, String lastName, String course, String section, float year, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.section = section;
            this.year = year;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public String introduceSelf()
        {
            return firstName + " " + lastName + " " + course + " " + year + " " + section;
        }

        public void evaluateGrade()
        {
            float Average = (midtermGrade + finalGrade) / 2;
            if(Average > 100)
            {
                Console.WriteLine("Invalid Grade");
            }else if(Average > 98)
            {
                Console.WriteLine("With Highest Honors");
            }else if(Average > 95)
            {
                Console.WriteLine("With High Honors");
            }else if(Average > 90)
            {
                Console.WriteLine("With Honors");
            }else if(Average > 75)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            
        }
    }
}