using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    /// <summary>
    /// Session's service interface that declares a single method `AuthenticateEmployee`. 
    /// 
    public interface ISessionService
    {
        /// <summary>
        /// Authenticates an Employee by verifying the provided email and password.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool AuthenticateEmployee(string email, string password);

        /// <summary>
        /// Method declaration for registering a new Employee with specified details and role.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        Employee RegisterEmployee(string name, string email, string password, int roleId);
    }
}
