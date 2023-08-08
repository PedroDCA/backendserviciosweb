using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class ProductionPlanning
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public List<ProductProcessData> ProductionProcesses { get; set; }
    }
}
