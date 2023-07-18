using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class SessionService : ISessionService
    {
        //Create the service interface
        private IEmployeeService _employeeService;

        //Create a constructor
        /// <summary>
        /// Constructor that initializes a new instance of the `SessionService` class, it allows the `SessionService` class to interact with the `employeeService` object.
        /// </summary>
        public SessionService(IEmployeeService employeeService) 
        { 
            _employeeService = employeeService;
        }

        //Create the funcion
        /// <summary>
        /// Method that verifies the credentials of an employee.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool AuthenticateEmployee(string email, string password)
        {
            var employee = _employeeService.GetEmployee(email, password);
            return employee.Id > 0;
        }

        /// <summary>
        /// Registers a new Employee by calling the PostEmployee method from the EmployeeService.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName">Employee's last name</param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public Employee RegisterEmployee(string name, string lastName, string email, string password, int roleId)
        {
            var employee = _employeeService.CreateEmployee(name, lastName, email, password, roleId);
            return employee;
        }

    }
}
