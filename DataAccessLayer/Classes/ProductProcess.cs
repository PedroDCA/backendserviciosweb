using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class ProductProcess
    {
        /// <summary>
        /// Identificator of the process for a product
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// References to the product identificator that will be created,
        /// </summary>
        public int ProductIdToCreate { get; set; }
        /// <summary>
        /// References the process' identificator that will be done
        /// </summary>
        public int ProcessId { get; set; }
        /// <summary>
        /// References the process step that will take place
        /// </summary>
        public int ProductionStep { get; set; }
        /// <summary>
        /// Amount of time in minutes that will take for the process to be finished.
        /// </summary>
        public int MinutesRequired { get; set; }
    }
}
