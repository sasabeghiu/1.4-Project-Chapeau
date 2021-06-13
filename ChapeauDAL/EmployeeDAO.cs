using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        private Employee Reademployee(SqlDataReader reader)
        {
            //retrieve data from all fields
            int employee_Number = (int)reader["employee_number"];
            string first_Name = (string)reader["first_name"];
            string last_Name = (string)reader["last_name"];
            string employee_Password = (string)reader["employee_password"];
            EmployeeRole role = (EmployeeRole)reader["employee_role"];

            //return new employee object
            return new Employee(employee_Number, first_Name, last_Name, employee_Password, role);
        }

        //Alexandru did following 2 methods for login
        public Employee GetEmployeeByPassword(string password)
        {
            string query = "SELECT employee_number, first_name, last_name, employee_role, employee_password FROM Employee WHERE employee_password = @employee_password";
            SqlParameter[] sqlParameters = { new SqlParameter("@employee_password", password), };
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadEmployee(DataTable dataTable)
        {
            Employee employee = null;
            foreach (DataRow dr in dataTable.Rows)
            {
                employee = new Employee()
                {
                    Employee_Number = (int)(dr["employee_number"]),
                    First_Name = (string)(dr["first_name"]),
                    Last_Name = ((string)dr["last_name"]),
                    Employee_Role = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), dr["employee_role"].ToString()),
                    Employee_Password = ((string)dr["employee_password"])
                };
            }
            return employee;
        }
    }
}
