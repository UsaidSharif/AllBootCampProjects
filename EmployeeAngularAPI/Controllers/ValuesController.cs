using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;



namespace EmployeeAngularAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Employee> Get()
        {
            Employee employee = new Employee(0, "", true, "");
            List<Employee> EmployeeList = employee.GetList();

            return EmployeeList;
        }

        // GET api/values/5
        public Employee Get(int id)
        {
            Employee employee = new Employee(0, "", true, "");
            List<Employee> EmployeeList = employee.GetList();
            Employee getDetails = new Employee(0, "", true, "");

            for(int i=0;i<EmployeeList.Count;i++)
            {
                if(id==EmployeeList[i].id)
                {
                    getDetails = EmployeeList[i];
                }
            }
            return getDetails;
        }

        // POST api/values
        public void Post([FromBody]Employee employee)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["ProjectAPI"].ConnectionString; ;
            SqlConnection mycnn;

            mycnn = new SqlConnection(connetionString);
            mycnn.Open();
            SqlCommand command;

            string sql = "Insert into EmployeeData2 values(@name,@gender,@role)";
            command = new SqlCommand(sql, mycnn);

            command.Parameters.AddWithValue("@name", employee.name);
            command.Parameters.AddWithValue("@gender", employee.gender);
            command.Parameters.AddWithValue("@role", employee.role);
            command.ExecuteNonQuery();
            command.Dispose();
            mycnn.Close();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Employee employee)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["ProjectAPI"].ConnectionString; ;
            SqlConnection mycnn;

            mycnn = new SqlConnection(connetionString);
            mycnn.Open();
            SqlCommand command;

            string sql = "Update EmployeeData2 set name=@name,gender=@gender,role=@role where id=@id";
            command = new SqlCommand(sql, mycnn);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@name", employee.name);
            command.Parameters.AddWithValue("@gender", employee.gender);
            command.Parameters.AddWithValue("@role", employee.role);
            command.ExecuteNonQuery();
            command.Dispose();
            mycnn.Close();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["ProjectAPI"].ConnectionString; ;
            SqlConnection mycnn;

            mycnn = new SqlConnection(connetionString);
            mycnn.Open();
            SqlCommand command;
            
            string sql = "Delete EmployeeData2 where id=@id";
            command = new SqlCommand(sql, mycnn);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Dispose();
            mycnn.Close();
        }
    }
}