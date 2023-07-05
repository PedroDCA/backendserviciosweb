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
        ///  Method that takes in an email and password as parameters and returns a boolean value indicating whether the employee is successfully authenticated or not.
        /// </summary>
        bool AuthenticateEmployee(string email, string password);
    }
}
