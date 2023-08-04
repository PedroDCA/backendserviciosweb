using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class PersonCharge
    {
        /// <summary>
        /// PersonCharge's identificator
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// References to the product process that will be done
        /// </summary>
        public int ProductProcessId { get; set; }
        /// <summary>
        /// References the employee's id in charge of this process
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// References to the date in which this will take place
        /// </summary>
        public int CalendarId { get; set; }
    }
}
