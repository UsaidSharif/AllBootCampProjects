using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeAngularAPI
{
    public class Employee
    {
       public int id { get; set; }
        public string name { get; set; }
        public bool gender { get; set; }
        public string role { get; set; }

        public Employee(int id, string name, bool gender, string role)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.role = role;
        }

         public List<Employee> GetList()
        {
            string connetionString = ConfigurationManager.ConnectionStrings["ProjectAPI"].ConnectionString; ;
            SqlConnection mycnn;

            mycnn = new SqlConnection(connetionString);
            mycnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "Select * From EmployeeData2";
            command = new SqlCommand(sql, mycnn);
            dataReader = command.ExecuteReader();

            List<Employee> EmployeeList = new List<Employee>();

            while (dataReader.Read())
            {
                int id = Convert.ToInt32(dataReader.GetValue(0));
                string name = dataReader.GetValue(1).ToString();
                bool gender = Convert.ToBoolean(dataReader.GetValue(2));
                string role = dataReader.GetValue(3).ToString();
                Employee account = new Employee(id, name, gender, role);
                EmployeeList.Add(account);
            }

            dataReader.Close();
            command.Dispose();
            mycnn.Close();
            return EmployeeList;
        }
    

    }
}