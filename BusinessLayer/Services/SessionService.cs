using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.ServiceInterfaces;
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
        public bool AuthenticateEmployee(string email, string password)
        {
            var employee = _employeeService.GetEmployee(email, password);
            return employee.Id > 0;
        }
    }
}
