using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController
    {
        //Contructor used to inject the IProcessService interface
        private readonly IProcessService _processService;

        public ProcessController(IProcessService processService)
        {
            _processService = processService;
        }

        // HTTP GET action to get all processes information
        [HttpGet("GetAllProcesses")]
        public List<ProcessData> GetAllProcessesInformation()
        {
            List<ProcessData> processesInformation = _processService.GetAllProcesses();

            return processesInformation;
        }

        // HTTP POST action to add a process
        [HttpPost("AddProcess")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] AddProcessRequest request)
        {
            // Extract registration data from the HTTP request
            string name = request.Name;
            int toolId = request.ToolId;
            int roleId = request.RoleId;

            // Call the registration service to register the process
            var newProcess = _processService.AddProcess(name, toolId, roleId);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Process added successfully",
                Id = newProcess.Id,
            };

            return response;

        }
    }
}
