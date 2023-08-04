using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccesses;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Services
{
    /// <summary>
    /// Defines a class named EmployeeDataAccess that implements the IEmployeeDataAccess interface.
    /// </summary>
    public class EmployeeDataAccess : IEmployeeDataAccess
    {

        private readonly MySQLConnection _context;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public EmployeeDataAccess(MySQLConnection context)
        {
            _context = context;
        }

        /// <summary>
        /// This method returns an instance of the Employee class
        /// </summary>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <returns></returns>
        public Employee GetEmployee (string email, string password)
        {
            // Fetch the employee with the given email and password from the Employee DbSet in the database
            Employee employee = _context.Employee.FirstOrDefault(e => e.Email == email && e.Password == password);

            // If the employee with the given email and password is not found, return null or handle the error as needed
            return employee;
        }

        /// <summary>
        /// This method creates a new Employee record with default values and returns it. 
        /// </summary>
        /// <param name="name">Employee's name</param>
        /// <param name="lastName">Employee's last name</param>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <param name="roleId">Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer</param>
        /// <returns></returns>
        public Employee CreateEmployee(string name, string lastName, string email, string password, int roleId)
        {
            var employee = new Employee()
            {
                Id = 1,
                Name = name,
                LastName = lastName,
                Email = email,
                Password = password,
                RoleId = 1,
            };

            _context.Employee.Add(employee);
            _context.SaveChanges();

            return employee;
        }

        /// <summary>
        /// Method that returns a list of all of the employees and their information
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployees()
        {
            List<Employee> result = _context.Employee.ToList();
            return result;
        }
           
    }
}
