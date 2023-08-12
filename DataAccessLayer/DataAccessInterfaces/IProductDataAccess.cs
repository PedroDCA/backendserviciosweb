using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccessInterfaces
{
    public interface IProductDataAccess
    {
        /// <summary>
        /// Method to get all the products in the database
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts();

        /// <summary>
        /// Method that adds a product in the database
        /// </summary>
        /// <param name="name">Product's name</param>
        /// <returns></returns>
        public Product CreateProduct(string name);
    }
}
