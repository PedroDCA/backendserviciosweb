using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class MaterialService : IMaterialService
    {
        private IMaterialDataAccess _materialDataAccess;

        /// <summary>
        /// Constructor that initializes a new instance of the `MaterialService` class, it allows the `MaterialService` class to interact with the `materialService` object.
        /// </summary>
        public MaterialService(IMaterialDataAccess materialDataAccess)
        {
            _materialDataAccess = materialDataAccess;
        }
        public List<Material> GetAllMaterials()
        {
            var materialList = _materialDataAccess.GetAllMaterials();
            return materialList;
        }

        public Material AddMaterial(string name, int quantity)
        {
            var material = _materialDataAccess.CreateMaterial(name, quantity);
            return material;
        }
    }
}
