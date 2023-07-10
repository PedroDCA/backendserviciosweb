using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductionDataAccessLayer.Classes
{
    public class Employee
    {
       /// <summary>
       /// Employee's Identificator
       /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Employee's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Employee's email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Employee's last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Employee's password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer
        /// </summary>
        public int RoleId { get; set; }
        
    }
}
