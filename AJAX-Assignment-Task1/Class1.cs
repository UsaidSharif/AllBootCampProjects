using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJAX_Assignment_Task1
{
    public class Student
    {
        public string  name { get; set; }
        public int age { get; set; }
        public int idNumber { get; set; }


        public Student(string Name, int Age, int Id)
        {
            this.name = Name;
            this.age = Age;
            this.idNumber = Id;
        }
    }

}