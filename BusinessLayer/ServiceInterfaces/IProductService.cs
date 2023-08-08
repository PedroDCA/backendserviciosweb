using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    public interface IProductService
    {
        /// <summary>
        /// Method that returns a list of all the Products
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts();

        /// <summary>
        /// Method declaration for adding a new Product with name
        /// </summary>
        /// <param name="name">Product's name</param>
        /// <returns></returns>
        public Product AddProduct(string name);

    }
}
