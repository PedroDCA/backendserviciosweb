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
        //Crear la interfaz del servicio
        private IEmployeeService _employeeService;

        //Crear un constructor
        public SessionService(IEmployeeService employeeService) 
        { 
            _employeeService = employeeService;
        }

        //Funcion
        public bool AuthenticateEmployee(string email, string password)
        {
            var employee = _employeeService.GetEmployee(email, password);
            return employee.Id > 0;
        }
    }
}
