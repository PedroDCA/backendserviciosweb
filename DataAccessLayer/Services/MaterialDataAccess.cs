using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Services
{
    public class MaterialDataAccess : IMaterialDataAccess
    {
        public List<Material> GetAllMaterials()
        {
            var material1 = new Material()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Name = "Madera",
                Quantity = 100,
            };
            var material2 = new Material()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 2,
                Name = "Goma",
                Quantity = 100,
            };
            var material3 = new Material()
            {
                //MISSING: Aqui va la conexion a la BD
                Id = 3,
                Name = "Clavos",
                Quantity = 100,
            };
            return new List<Material>()
            {
                material1, material2, material3
            };
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
                //MISSING: Aqui va la conexion a la BD
                Id = 1,
                Name = " ",
                Quantity = 1,
            };

            return material;
        }
    }
}
