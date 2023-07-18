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
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Employee GetEmployee(string email, string password);

        /// <summary>
        /// Creates a new Employee record in the system with the provided details.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        Employee PostEmployee(string name, string email, string password, int roleId);
    }
}
