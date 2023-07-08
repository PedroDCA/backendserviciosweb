using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    internal class Tool
    {
        /// <summary>
        /// Tool's identificator
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Tool's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Tool's quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
