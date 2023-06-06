using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.Interfaces;
using ProductionBusinessLayer.Models;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialController : ControllerBase
    {
        private readonly IWorkerService _workerService;

        public MaterialController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        /// <summary>
        /// Gets a list of the current active workers for the production chain.
        /// </summary>
        /// <returns>A list of basic information of the current workers</returns>
        [HttpGet("GetActiveWorkers")]
        public IList<BasicWorkerInformation> GetActiveWorkers()
        {
            var activeWorkers = _workerService.GetBasicActiveWorkerInformation();

            return activeWorkers;
        }
    }
}
