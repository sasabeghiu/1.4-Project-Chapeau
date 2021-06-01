using ChapeauModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDao
    {
        private SqlConnection dbConnection;
        public EmployeeDAO()
        {

        }
        public List<Employee> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> employeesList = new List<Employee>();

            while (reader.Read())
            {
                Employee employee = Reademployee(reader);
                employeesList.Add(employee);
            }
            reader.Close();
            dbConnection.Close();

            return employeesList;

        }
        public Employee GetById(int employee_number)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE employee_number = @employee_number", dbConnection);

            command.Parameters.AddWithValue("@Id", employee_number);

            SqlDataReader reader = command.ExecuteReader();
            Employee employee = null;

            if (reader.Read())
            {
                employee = Reademployee(reader);
            }
            reader.Close();
            dbConnection.Close();

            return employee;
        }

        //sasa created this  for login
        public Employee GetEmployeePassword(int password)
        {
            Employee user  = new Employee();
            string query = $"SELECT * FROM Employee WHERE [employee_password] = {user.Employee_Password}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            return user;
             
        }

        private Employee Reademployee(SqlDataReader reader)
        {
            //retrieve data from all fields
            int employee_Number = (int)reader["employee_number"];
            string first_Name = (string)reader["first_name"];
            string last_Name = (string)reader["last_name"];
            int employee_Password = (int)reader["employee_password"];
            EmployeeRole role = (EmployeeRole)reader["employee_role"];

            //return new employee object
            return new Employee(employee_Number, first_Name, last_Name, employee_Password, role);
        }
    }
}
