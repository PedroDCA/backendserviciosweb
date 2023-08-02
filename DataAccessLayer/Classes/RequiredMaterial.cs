using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class RequiredMaterial
    {
        /// <summary>
        /// Required material's id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// References that production process identificator that will be processed.
        /// </summary>
        public int ProductProcessId { get; set; }
        /// <summary>
        /// References the material's identificator that will be needed for the process
        /// </summary>
        public int MaterialId { get; set; }
        /// <summary>
        /// Amount of material that will be needed for the process
        /// </summary>
        public int Quantity { get; set; }
    }
}
