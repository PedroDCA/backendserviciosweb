using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccessInterfaces
{
    public interface IProductProcessDataAccess
    {
        /// <summary>
        /// Method to get production planning information by product id.
        /// </summary>
        /// <param name="productId">References the product Id that will be used to search for the its id</param>
        /// <returns></returns>
        public ProductionPlanning GetProductionPlanningByProductId(int productId);

        /// <summary>
        /// Method to list production processes by Id.
        /// </summary>
        /// <param name="productId">References the product Id that will be used to search for the its id</param>
        /// <returns></returns>
        public List<ProductProcessData> GetProductionProcessesByProductId(int productId);

        /// <summary>
        /// This method creates a new ProductProcess record with given values and returns it.
        /// </summary>
        /// <param name="productId">References the product Id that will be used to search for the its id</param>
        /// <param name="processId">References the process' identificator that will be done</param>
        /// <param name="productionStep">References the process step that will take place</param>
        /// <param name="minutesRequired">Amount of time in minutes that will take for the process to be finished.</param>
        /// <returns></returns>
        public ProductProcess CreateProductProcess(int productId, int processId, int productionStep, int minutesRequired);

        /// <summary>
        /// Gets the required minutos for a production of a product by its product id.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns>The sum of the required minutes of all processes.</returns>
        public int GetRequiredMinutesForProductId(int productId);
    }
}
