using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    internal class Process
    {
        /// <summary>
        /// Process' identificator
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Process' name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Tool's id used for the process
        /// </summary>
        public int ToolId { get; set; }
        /// <summary>
        /// Role of the person needed to do the process
        /// </summary>
        public int RoleId { get; set; }

    }
}
