using ProductionBusinessLayer.Models;

namespace ProductionPresentationLayer.HttpRequest
{
    public class CreateProductionRequest
    {
        public int ProductId { get; set; }

        public DateTime StartDate { get; set; }

        public List<ProductionProcess> ProductionProcesses { get; set; }
    }
}
