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
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <returns></returns>
        bool AuthenticateEmployee(string email, string password);

        /// <summary>
        /// Method declaration for registering a new Employee with specified details and role.
        /// </summary>
        /// <param name="name">Employee's name</param>
        /// <param name="lastName">Employee's last name</param>
        /// <param name="email">Employee's email</param>
        /// <param name="password">Employee's password</param>
        /// <param name="roleId">Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer</param>
        /// <returns></returns>
        Employee RegisterEmployee(string name, string lastName, string email, string password, int roleId);
    }
}
