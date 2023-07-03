using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    public interface ISessionService
    {
        bool AuthenticateEmployee(string email, string password);
    }
}
