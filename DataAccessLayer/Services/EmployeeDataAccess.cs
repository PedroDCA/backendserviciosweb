using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Services
{
    /// <summary>
    /// Defines a class named EmployeeService that implements the IEmployeeService interface.
    /// </summary>
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        /// <summary>
        /// This method returns an instance of the Employee class
        /// </summary>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <returns></returns>
        public Employee GetEmployee (string email, string password)
        {
            var employee = new Employee()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Email = "pedrito@gmail.com",
                Password = "pedrito",
            };

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
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Name = " ",
                LastName = " ",
                Email = " ",
                Password = " ",
                RoleId = 1,
            };

            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            var employee1 = new Employee()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Name = "Nicole",
                LastName = " ",
                Email = " ",
                Password = " ",
                RoleId = 3,
            };
            var employee2 = new Employee()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Name = "Steven",
                LastName = " ",
                Email = " ",
                Password = " ",
                RoleId = 2,
            };
            var employee3 = new Employee()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Name = "Pedrooooooo",
                LastName = " ",
                Email = " ",
                Password = " ",
                RoleId = 4,
            };
            return new List<Employee>()
            {
                employee1, employee2, employee3
            };
        }
    }
}
