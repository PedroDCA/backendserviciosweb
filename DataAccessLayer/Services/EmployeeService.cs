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
        /// This method returns an instance of the Employee class with predefined values for demonstration purposes. 
        /// </summary>
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
    }
}
