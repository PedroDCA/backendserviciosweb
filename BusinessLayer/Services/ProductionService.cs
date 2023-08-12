using ProductionBusinessLayer.Models;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;

namespace ProductionBusinessLayer.Services
{
    public class ProductionService : IProductionService
    {
        private IProductProcessDataAccess _productProcessDataAccess;
        private IEmployeeDataAccess _employeeDataAccess;
        private ICalendarDataAccess _calendarDataAccess;

        /// <summary>
        /// Constructor for the ProductionService class that initializes the instance with three objects
        /// Implements: IEmployeeDataAccess, ICalendarDataAccess, and IProductProcessDataAccess.
        /// Enabled the service to access employee data, calendar data, and product process data.
        /// </summary>
        public ProductionService(IEmployeeDataAccess employeeDataAccess, ICalendarDataAccess calendarDataAccess, IProductProcessDataAccess productProcessDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
            _calendarDataAccess = calendarDataAccess;
            _productProcessDataAccess = productProcessDataAccess;
        }

        /// <inheritdoc />
        public ProductionPlanning GetProductionPlanningByProductId(int productId)
        {
            var productionPlanning = _productProcessDataAccess.GetProductionPlanningByProductId(productId);
            return productionPlanning;
        }

        /// <inheritdoc />
        public bool CreateProduction(int productId, DateTime startDate, List<ProductionProcess> productionProcesses)
        {
            var newProduction = _calendarDataAccess.StartNewProduction(productId, startDate);
            
            foreach (var productionProcess in productionProcesses)
            {
                _employeeDataAccess.SetPersonCharge(productionProcess.ProductProcessId, productionProcess.EmployeeChargeId, newProduction.Id);
            }

            return true;
        }
    }
}
