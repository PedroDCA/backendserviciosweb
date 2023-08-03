using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccesses;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Services
{
    /// <summary>
    /// Defines a class named MaterialDataAccess that implements the IMaterialDataAccess interface.
    /// </summary>
    public class MaterialDataAccess : IMaterialDataAccess
    {
        private readonly MySQLConnection _context;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public MaterialDataAccess(MySQLConnection context)
        {
            _context = context;
        }

        /// <summary>
        /// This method returns a list of all the materials in record with their information
        /// </summary>
        /// <returns></returns>
        public List<Material> GetAllMaterials()
        {
            List<Material> result = _context.Material.ToList();
            return result;
        }


        /// <summary>
        /// This method creates a new Material record with default values and returns it. 
        /// </summary>
        /// <param name="name">Material's name</param>
        /// <param name="quantity">Material's quantity</param>
        /// <returns></returns>
        public Material CreateMaterial(string name, int quantity)
        {
            var material = new Material()
            {
                Name = name,
                Quantity = quantity,
            };

            _context.Material.Add(material);
            _context.SaveChanges();

            return material;
        }
    }
}
