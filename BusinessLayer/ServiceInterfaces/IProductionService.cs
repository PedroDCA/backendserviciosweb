using ProductionBusinessLayer.Models;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    public interface IProductionService
    {
        public bool CreateProduction(int productId, DateTime startDate, List<ProductionProcess> productionProcesses);

        public ProductionPlanning GetProductionPlanningByProductId(int productId);

    }
}
