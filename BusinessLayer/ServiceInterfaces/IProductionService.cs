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
        /// <summary>
        /// Retrieves the production planning information for a given product ID.
        /// </summary>
        /// <param name="productId">The ID of the product for which to retrieve production planning.</param>
        public ProductionPlanning GetProductionPlanningByProductId(int productId);


        /// <summary>
        /// Creates a new production process for a product starting at the specified date,
        /// </summary>
        /// <param name="productId">The ID of the product for which to create a production process.</param>
        /// <param name="startDate">The start date of the production process.</param>
        /// <param name="productionProcesses">The list of production processes with assigned employees.</param>
        public bool CreateProduction(int productId, DateTime startDate, List<ProductionProcess> productionProcesses);

        /// <summary>
        /// Gets the information about all the productions.
        /// </summary>
        /// <returns>The list with all the productions.</returns>
        public List<CalendarData> GetAllProductions();
    }
}
