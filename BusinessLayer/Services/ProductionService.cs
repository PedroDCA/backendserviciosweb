using ProductionBusinessLayer.Models;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;

namespace ProductionBusinessLayer.Services
{
    public class ProductionService : IProductionService
    {
        private readonly IProductProcessDataAccess _productProcessDataAccess;
        private readonly IEmployeeDataAccess _employeeDataAccess;
        private readonly ICalendarDataAccess _calendarDataAccess;
        private readonly IMaterialDataAccess _materialDataAccess;

        /// <summary>
        /// Constructor for the ProductionService class that initializes the instance with three objects
        /// Implements: IEmployeeDataAccess, ICalendarDataAccess, and IProductProcessDataAccess.
        /// Enabled the service to access employee data, calendar data, and product process data.
        /// </summary>
        public ProductionService(IEmployeeDataAccess employeeDataAccess, ICalendarDataAccess calendarDataAccess, IProductProcessDataAccess productProcessDataAccess, IMaterialDataAccess materialDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
            _calendarDataAccess = calendarDataAccess;
            _productProcessDataAccess = productProcessDataAccess;
            _materialDataAccess = materialDataAccess;
        }

        /// <inheritdoc />
        public ProductionPlanning GetProductionPlanningByProductId(int productId)
        {
            var productionPlanning = _productProcessDataAccess.GetProductionPlanningByProductId(productId);
            return productionPlanning;
        }

        /// <summary>
        /// Gets the required days that a product production.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns>The number of days required.</returns>
        private int GetRequiredDaysFromProductId(int productId)
        {
            var minutesRequired = _productProcessDataAccess.GetRequiredMinutesForProductId(productId);
            var daysRequired = Math.Floor((double) (minutesRequired / 60) / 8);

            return (int) daysRequired;
        }

        /// <summary>
        /// Reduces the material quantity.
        /// </summary>
        /// <param name="materialId">The material identifier.</param>
        /// <param name="quantityToReduce">The quantity that will be removed.</param>
        /// <returns>A bool value when it was done.</returns>
        private bool ReduceMaterialAvailability(int materialId, int quantityToReduce)
        {
            var currentMaterialQuantity = _materialDataAccess.GetMaterialById(materialId);
            var newQuantity = currentMaterialQuantity.Quantity - quantityToReduce;
            _materialDataAccess.EditMaterialQuantity(materialId, newQuantity);

            return true;
        }

        /// <summary>
        /// Updates all the material availability that are used on the product process.
        /// </summary>
        /// <param name="productProcessId">Product Process Identifier.</param>
        /// <returns>A boolean value when it was done.</returns>
        private bool UpdateMaterialsByNewProductProcess(int productProcessId)
        {
            var requiredMaterialList = _materialDataAccess.GetRequiredMaterialsByProductProcessId(productProcessId);
            foreach (var requiredMaterial in requiredMaterialList)
            {
                ReduceMaterialAvailability(requiredMaterial.MaterialId, requiredMaterial.Quantity);
            }

            return true;
        }

        /// <inheritdoc />
        public bool CreateProduction(int productId, DateTime startDate, List<ProductionProcess> productionProcesses)
        {
            var daysRequired = GetRequiredDaysFromProductId(productId);
            var endDate = startDate.AddDays(daysRequired);

            var newProduction = _calendarDataAccess.StartNewProduction(productId, startDate, endDate);
            foreach (var productionProcess in productionProcesses)
            {
                // Sets the person that will be in charge for each product process.
                _employeeDataAccess.SetPersonCharge(productionProcess.ProductProcessId, productionProcess.EmployeeChargeId, newProduction.Id);

                // Updates the material availability of each material that is used on this product process.
                UpdateMaterialsByNewProductProcess(productionProcess.ProductProcessId);
            }

            return true;
        }

        /// <summary>
        /// Gets the production information with the formatting for the page.
        /// </summary>
        /// <param name="rawProductionInformation">The producion information in raw.</param>
        /// <returns>The production information to be used.</returns>
        private CalendarData GetProductionFormatted(CalendarData rawProductionInformation)
        {
            var formattedProduction = new CalendarData
            {
                ProductName = rawProductionInformation.ProductName,
                StartDate = rawProductionInformation.StartDate.AddHours(8),
                EndDate = rawProductionInformation.EndDate,
            };

            return formattedProduction;
        }

        /// <inheritdoc />
        public List<CalendarData> GetAllProductions()
        {
            var allProductions = _calendarDataAccess.GetAllCalendarInformation();

            var formattedProductions = allProductions.Select(GetProductionFormatted).ToList();
            return formattedProductions;
        }
    }
}
