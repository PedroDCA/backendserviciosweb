using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionBusinessLayer.Services;
using ProductionDataAccessLayer.Classes;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolController
    {
        //Contructor used to inject the IEmployeeService interface
        private readonly IToolService _toolService;

        public ToolController(IToolService toolService)
        {
            _toolService = toolService;
        }

        // HTTP GET action to get all Tools information
        [HttpGet("GetAllTools")]
        public List<Tool> GetAllToolsInformation()
        {
            List<Tool> toolsInformation = _toolService.GetAllTools();

            return toolsInformation;
        }

        // HTTP POST action to add a Tool
        [HttpPost("AddTool")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] AddToolRequest request)
        {
            // Extract registration data from the HTTP request
            string name = request.Name;
            int quantity = request.Quantity;

            // Call the registration service to register the material
            var newTool = _toolService.AddTool(name, quantity);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Tool added successfully",
                Id = newTool.Id,
            };

            return response;

        }
    }
}
