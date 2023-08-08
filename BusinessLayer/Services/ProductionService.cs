using ProductionBusinessLayer.Models;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class ProductionService : IProductionService
    {
        private IProductProcessDataAccess _productProcessDataAccess;
        private IEmployeeDataAccess _employeeDataAccess;
        private ICalendarDataAccess _calendarDataAccess;

        public ProductionService(IEmployeeDataAccess employeeDataAccess, ICalendarDataAccess calendarDataAccess, IProductProcessDataAccess productProcessDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
            _calendarDataAccess = calendarDataAccess;
            _productProcessDataAccess = productProcessDataAccess;
        }

        public ProductionPlanning GetProductionPlanningByProductId(int productId)
        {
            var productionPlanning = _productProcessDataAccess.GetProductionPlanningByProductId(productId);
            return productionPlanning;
        }

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
