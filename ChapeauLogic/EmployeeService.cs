using System.Collections.Generic;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDAO employeedb;

        public EmployeeService()
        {
            employeedb = new EmployeeDAO();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = employeedb.GetAll();
            return employeeList;

        }
        //menu by id?
        public Employee GetByMenuId(int employee_number)
        {
            Employee employee = employeedb.GetById(employee_number);
            return employee;
        }

        public Employee GetEmployeePassword(int password)
        {
            Employee user = employeedb.GetEmployeePassword(password);
            return user;
        }
    }
}
