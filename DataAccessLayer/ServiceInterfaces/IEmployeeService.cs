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
        Employee GetEmployee(string email, string password);
    }
}
