using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccesses;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class ProductProcessService : IProductProcessService
    {
        private IProductProcessDataAccess _productProcessDataAccess;
        /// <summary>
        /// Constructor that initializes a new instance of the `ProcessService` class, it allows the `ProcessService` class to interact with the `IProcessService` object.
        /// </summary>
        public ProductProcessService(IProductProcessDataAccess productProcessDataAccess)
        {
            _productProcessDataAccess = productProcessDataAccess;
        }

        

    }
}
