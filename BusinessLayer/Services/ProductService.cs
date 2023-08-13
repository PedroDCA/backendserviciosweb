using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using ProductionPresentationLayer.HttpRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDataAccess _productDataAccess;
        private readonly IProductProcessDataAccess _productProcessDataAccess;
        private readonly IMaterialDataAccess _materialDataAccess;

        /// <summary>
        /// Constructor for the ProductService class that initializes the instance with an object, implementing the IProductDataAccess interface, allowing access to product data.
        /// </summary>
        public ProductService(IProductDataAccess productlDataAccess, IProductProcessDataAccess productProcessDataAccess, IMaterialDataAccess materialDataAccess)
        {
            _productDataAccess = productlDataAccess;
            _productProcessDataAccess = productProcessDataAccess;
            _materialDataAccess = materialDataAccess;
        }

        /// <inheritdoc />
        public List<Product> GetAllProducts()
        {
            var productList = _productDataAccess.GetAllProducts();
            return productList;
        }

        /// <inheritdoc />
        public Product AddProduct(string name, List<RequestedStepInformation> steps)
        {
            var product = _productDataAccess.CreateProduct(name);
            foreach (var step in steps)
            {
                var newProductProcess = _productProcessDataAccess.CreateProductProcess(product.Id, step.ProcessId, steps.IndexOf(step) + 1, step.MinutesRequired);
                foreach (var material in step.Materials)
                {
                    _materialDataAccess.CreateRequiredMaterialForProcess(newProductProcess.Id, material.Id, material.Quantity);
                }
            }

            return product;
        }
    }
}
