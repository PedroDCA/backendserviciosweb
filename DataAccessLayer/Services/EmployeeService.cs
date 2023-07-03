using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee (string email, string password)
        {
            var employee = new Employee()
            {
                Id = 1,
                Email = "pedrito@gmail.com",
                Password = "pedrito",
            };

            return employee;
        }
    }
}
