using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private IProductDataAccess _productDataAccess;

        /// <summary>
        /// Constructor for the ProductService class that initializes the instance with an object, implementing the IProductDataAccess interface, allowing access to product data.
        /// </summary>
        public ProductService(IProductDataAccess productlDataAccess)
        {
            _productDataAccess = productlDataAccess;
        }

        /// <inheritdoc />
        public List<Product> GetAllProducts()
        {
            var productList = _productDataAccess.GetAllProducts();
            return productList;
        }

        /// <inheritdoc />
        public Product AddProduct(string name)
        {
            var product = _productDataAccess.CreateProduct(name);
            return product;
        }
    }
}
