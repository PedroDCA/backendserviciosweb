using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialController
    {
        //Contructor used to inject the IEmployeeService interface
        private readonly IMaterialService _materialService;

        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        // HTTP GET action to get all employees information
        [HttpGet("GetAllMaterial")]
        public List<Material> GetAllMaterialsInformation()
        {
            List<Material> materialsInformation = _materialService.GetAllMaterials();

            return materialsInformation;
        }

        // HTTP POST action to add an employee
        [HttpPost("AddMaterial")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] AddMaterialRequest request)
        {
            // Extract registration data from the HTTP request
            string name = request.Name;
            int quantity = request.Quantity;

            // Call the registration service to register the employee
            var newMaterial = _materialService.AddMaterial(name, quantity);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Material added successfully",
                Id = newMaterial.Id,
            };

            return response;

        }

    }
}
