using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionPresentationLayer.HttpRequest;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductionController
    {
        //Contructor used to inject the IProductionService interface
        private readonly IProductionService _productionService;

        public ProductionController(IProductionService productionService)
        {
            _productionService = productionService;
        }

        // HTTP POST action to add a production process
        [HttpPost("StartProduction")]

        public bool HandleCreateProductionRequest([FromBody] CreateProductionRequest request)
        {
            var wasProductionCreated = _productionService.CreateProduction(request.ProductId, request.StartDate, request.ProductionProcesses);

            return wasProductionCreated;
        }

        // HTTP GET action to get a planning of a product by Id
        [HttpGet("GetPlanning")]

        public ProductionPlanning HandleGetPlanningRequest(int productId)
        {
            var productionPlanning = _productionService.GetProductionPlanningByProductId(productId);

            return productionPlanning;
        }

    }
}
