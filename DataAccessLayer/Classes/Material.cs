using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    internal class Material
    {
        /// <summary>
        /// Material's identificator
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Material's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Material's quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
