using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        //Contructor used to inject the IProductService interface
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // HTTP GET action to get all products information
        [HttpGet("GetAllProducts")]
        public List<Product> GetAllProductsInformation()
        {
            List<Product> productsInformation = _productService.GetAllProducts();

            return productsInformation;
        }

        // HTTP POST action to add a product
        [HttpPost("AddProduct")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] AddProductRequest request)
        {
            // Extract registration data from the HTTP request
            string name = request.Name;

            // Call the registration service to register the material
            var newProduct = _productService.AddProduct(name, request.Steps);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Product added successfully",
                Id = newProduct.Id,
            };

            return response;

        }

    }
}
