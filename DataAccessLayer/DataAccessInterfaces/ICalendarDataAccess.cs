using ProductionDataAccessLayer.Classes;

namespace ProductionDataAccessLayer.DataAccessInterfaces
{
    public interface ICalendarDataAccess
    {
        /// <summary>
        /// Sets the information to start a new production.
        /// </summary>
        /// <param name="productIdToCreate">Product's Id that will be created in the production process</param>
        /// <param name="startDate">Date in which the process will start</param>
        /// <param name="startDate">Date in which the process will start</param>
        /// <returns>The calendar information created.</returns>
        public Calendar StartNewProduction(int productIdToCreate, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Gets the information related to all the productions that were done and will be done.
        /// </summary>
        /// <returns>The list with the calendar data.</returns>
        public List<CalendarData> GetAllCalendarInformation();
    }
}
