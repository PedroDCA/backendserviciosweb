using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Method that returns a list of all the employees
        /// </summary>
        /// <returns></returns>
        List<Employee> GetAllEmployees();
        /// <summary>
        /// Method declaration for adding a new Employee with specified details and role.
        /// </summary>
        /// <param name="name">Employee's name</param>
        /// <param name="lastName">Employee's last name</param>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <param name="roleId">Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer</param>
        /// <returns></returns>
        Employee AddEmployee(string name, string lastName, int roleId);


    }
}
