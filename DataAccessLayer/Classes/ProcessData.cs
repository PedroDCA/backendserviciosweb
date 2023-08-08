using Microsoft.EntityFrameworkCore;
using ProductionDataAccessLayer.DataAccesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class ProcessData
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
        /// New class of Tool called Tool
        /// </summary>
        public Tool Tool { get; set; }

        /// <summary>
        /// New class of Role called Role
        /// </summary>

        public Role Role { get; set; }


    }
}
