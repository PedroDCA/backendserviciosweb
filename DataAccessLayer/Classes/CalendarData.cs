using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class CalendarData
    {
        /// <summary>
        /// Gets or sets the product name that is related to the calendar information.
        /// </summary>
        public string ProductName { get; set; }
        
        /// <summary>
        /// Ges or sets the date when the production started.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the production should have ended.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
