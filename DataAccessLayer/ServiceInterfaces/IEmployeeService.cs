using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.ServiceInterfaces
{
    /// <summary>
    /// Employee's Service Interface, that declares the method `GetEmployee`.  
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Method that takes in an email and password as parameters and returns an instance of the `Employee` class.
        /// </summary>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <returns></returns>
        Employee GetEmployee(string email, string password);

        /// <summary>
        /// Creates a new Employee record in the system with the provided details.
        /// </summary>
        /// <param name="name">Employee's name</param>
        /// <param name="lastName">Employee's last name</param>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <param name="roleId">Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer</param>
        /// <returns></returns>
        Employee CreateEmployee(string name, string lastName, string email, string password, int roleId);
    }
}
