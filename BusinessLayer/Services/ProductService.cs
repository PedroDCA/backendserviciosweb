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
        /// Constructor that initializes a new instance of the `MaterialService` class, it allows the `MaterialService` class to interact with the `materialService` object.
        /// </summary>
        public ProductService(IProductDataAccess productlDataAccess)
        {
            _productDataAccess = productlDataAccess;
        }

        public List<Product> GetAllProducts()
        {
            var productList = _productDataAccess.GetAllProducts();
            return productList;
        }

        public Product AddProduct(string name)
        {
            var product = _productDataAccess.CreateProduct(name);
            return product;
        }
        /*
        public bool CreateNewProductPlan(string productName, List)
        {

        }
        */
    }
}
