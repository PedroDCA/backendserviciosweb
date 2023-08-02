using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeDataAccess _employeeDataAccess;

        /// <summary>
        /// Constructor that initializes a new instance of the `SessionService` class, it allows the `SessionService` class to interact with the `employeeService` object.
        /// </summary>
        public EmployeeService(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployees()
        {
            var employeeList = _employeeDataAccess.GetAllEmployees();
            return employeeList;
        }
        /// <summary>
        /// Adds a new Employee by calling the CreateEmployee method from the EmployeDataAccess.
        /// </summary>
        /// <param name="name">Employee's name</param>
        /// <param name="lastName">Employee's last name</param>
        /// <param name="roleId">Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer</param>
        /// <returns></returns>
        public Employee AddEmployee(string name, string lastName, int roleId)
        {
            var employee = _employeeDataAccess.CreateEmployee(name, lastName, string.Empty, string.Empty, roleId);
            return employee;
        }


    }
}
