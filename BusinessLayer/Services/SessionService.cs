using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;

namespace ProductionBusinessLayer.Services
{
    public class SessionService : ISessionService
    {
        private IEmployeeDataAccess _employeeDataAccess;

        /// <summary>
        /// Constructor for the SessionService class that initializes the instance with an object, implementing the IEmployeeDataAccess interface, allowing access to employee data.
        /// </summary>
        public SessionService(IEmployeeDataAccess employeeDataAccess) 
        {
            _employeeDataAccess = employeeDataAccess;
        }

        /// <inheritdoc />
        public bool AuthenticateEmployee(string email, string password)
        {
            var employee = _employeeDataAccess.GetEmployee(email, password);
            return employee.Id > 0;
        }

        /// <inheritdoc />
        public Employee RegisterEmployee(string name, string lastName, string email, string password, int roleId)
        {
            var employee = _employeeDataAccess.CreateEmployee(name, lastName, email, password, roleId);
            return employee;
        }

    }
}
