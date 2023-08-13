using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialController
    {
        //Contructor used to inject the IMaterialService interface
        private readonly IMaterialService _materialService;

        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        // HTTP GET action to get all materials information
        [HttpGet("GetAllMaterials")]
        public List<Material> GetAllMaterialsInformation()
        {
            List<Material> materialsInformation = _materialService.GetAllMaterials();

            return materialsInformation;
        }

        // HTTP POST action to add a material
        [HttpPost("AddMaterial")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] AddMaterialRequest request)
        {
            // Extract registration data from the HTTP request
            string name = request.Name;
            int quantity = request.Quantity;

            // Call the registration service to register the material
            var newMaterial = _materialService.AddMaterial(name, quantity);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Material added successfully",
                Id = newMaterial.Id,
            };

            return response;

        }

        // HTTP POST action to edit a material
        [HttpPost("EditMaterial")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] EditMaterialRequest request)
        {
            // Extract registration data from the HTTP request
            int id = request.Id;
            int quantity = request.Quantity;

            // Call the registration service to register the material
            var newMaterial = _materialService.EditMaterialQuantity(id, quantity);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Material's quantity was updated successfully",
                Id = newMaterial.Id,
            };

            return response;

        }

    }
}
