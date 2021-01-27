using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Student
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }
//Press Alt + Shift + up/down arrows for a multitype in VS
        

        //Default/Empty Constructor for the Student Class that sets every property to its starting value 
        public Student()
        {
            ID = 0;
            FirstName = "";
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }
//CTOR tab tab creates a constructor for you 
        public Student(int id, string first, string last, string color)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;
        }


        //Example if id was the only variable called in the constructor 
        //public Student(int id)
        //{
        //    ID = id;
        //    FirstName = "";
        //    LastName = string.Empty;
        //    FavoriteColor = string.Empty;
        //}
        ////Or
        //public Student(int id) : this()
        //{
        //    ID = id;
        //}

        public string CreateFullName()
        {
            return $"{LastName}, {FirstName}";
        }


    }
}
