using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    internal class Calendar
    {
        /// <summary>
        /// Calendar's identificator
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// References the product that will be created
        /// </summary>
        public int ProductIdToCreate { get; set; }
        /// <summary>
        /// Date in which the product will be created
        /// </summary>
        public DateOnly StartDate { get; set;}
    }
}
