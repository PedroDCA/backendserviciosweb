using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;

namespace ProductionBusinessLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeDataAccess _employeeDataAccess;

        /// <summary>
        /// Constructor for the EmployeeService class that initializes the instance with an object, implementing the IEmployeeDataAccess interface, allowing access to employee data.
        /// </summary>
        public EmployeeService(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }

        /// <inheritdoc />
        public List<Employee> GetAllEmployees()
        {
            var employeeList = _employeeDataAccess.GetAllEmployees();
            return employeeList;
        }

        /// <inheritdoc />
        public Employee AddEmployee(string name, string lastName, int roleId)
        {
            var employee = _employeeDataAccess.CreateEmployee(name, lastName, string.Empty, string.Empty, roleId);
            return employee;
        }


    }
}
