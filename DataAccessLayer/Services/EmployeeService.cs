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
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// This method returns an instance of the Employee class
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
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
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public Employee CreateEmployee(string name, string email, string password, int roleId)
        {
            var employee = new Employee()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Name = " ",
                Email = " ",
                Password = " ",
                RoleId = 1,
            };

            return employee;
        }
    }
}
