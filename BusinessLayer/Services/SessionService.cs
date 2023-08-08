using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;

namespace ProductionBusinessLayer.Services
{
    public class SessionService : ISessionService
    {
        //Create the service interface
        private IEmployeeDataAccess _employeeDataAccess;

        //Create a constructor
        /// <summary>
        /// Constructor that initializes a new instance of the `SessionService` class, it allows the `SessionService` class to interact with the `employeeService` object.
        /// </summary>
        public SessionService(IEmployeeDataAccess employeeDataAccess) 
        {
            _employeeDataAccess = employeeDataAccess;
        }

        //Create the funcion
        /// <summary>
        /// Method that verifies the credentials of an employee.
        /// </summary>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <returns></returns>
        public bool AuthenticateEmployee(string email, string password)
        {
            var employee = _employeeDataAccess.GetEmployee(email, password);
            return employee.Id > 0;
        }

        /// <summary>
        /// Registers a new Employee by calling the CreateEmployee method from the EmployeDataAccess.
        /// </summary>
        /// <param name="name">Employee's name</param>
        /// <param name="lastName">Employee's last name</param>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <param name="roleId">Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer</param>
        /// <returns></returns>
        public Employee RegisterEmployee(string name, string lastName, string email, string password, int roleId)
        {
            var employee = _employeeDataAccess.CreateEmployee(name, lastName, email, password, roleId);
            return employee;
        }

    }
}
