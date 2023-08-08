using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class ProductProcessData
    {
        /// <summary>
        /// Identificator of the process for a product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Amount of time in minutes that will take for the process to be finished.
        /// </summary>
        public int MinutesRequired { get; set; }

        public Role Role { get; set; }

        public List<Material> Materials { get; set; }
    }

}
