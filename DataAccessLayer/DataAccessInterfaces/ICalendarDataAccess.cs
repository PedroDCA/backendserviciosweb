using ProductionDataAccessLayer.Classes;

namespace ProductionDataAccessLayer.DataAccessInterfaces
{
    public interface ICalendarDataAccess
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productIdToCreate">Product's Id that will be created in the production process</param>
        /// <param name="startDate">Date in which the process will start</param>
        /// <returns></returns>
        public Calendar StartNewProduction(int productIdToCreate, DateTime startDate);
    }
}
