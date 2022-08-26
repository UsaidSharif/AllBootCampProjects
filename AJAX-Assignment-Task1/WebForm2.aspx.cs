using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AJAX_Assignment_Task1;
using System.Collections;
using System.Web.Services;

namespace AJAX_Assignment_Task1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student("Ali", 20, 1);
            students.Add(student1);


            Student student2 = new Student("Nadeem", 20, 2);
            students.Add(student2);

            Student student3 = new Student("Ali", 20, 3);
            students.Add(student3);

            Student student4 = new Student("Ali", 20, 4);
            students.Add(student4);

            Student student5 = new Student("Ali", 20, 5);
            students.Add(student5);

            dropdown.DataSource = students;
            dropdown.DataTextField = "name";
            dropdown.DataValueField = "idNumber";
            dropdown.DataBind();
        }
    }
}