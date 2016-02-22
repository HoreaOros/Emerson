using MVVM_WPF_HelloWorld.Model;
using System.Collections.Generic;

namespace MVVM_WPF_HelloWorld.DataAccess
{
    public class EmployeeRepository
    {
        readonly List<Employee> _employees;
        public EmployeeRepository()
        {
            if (_employees == null)
            {
                _employees = new List<Employee>();
            }
            _employees.Add(Employee.CreateEmployee("John", "Doe"));
            _employees.Add(Employee.CreateEmployee("Jane", "Doe"));
            _employees.Add(Employee.CreateEmployee("John", "Smith"));
            _employees.Add(Employee.CreateEmployee("Chris", "Brown"));
        }
        public List<Employee> GetEmployees()
        {
            return new List<Employee>(_employees);
        }
    }
}
