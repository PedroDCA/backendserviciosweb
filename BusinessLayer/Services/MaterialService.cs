using Microsoft.EntityFrameworkCore;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
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
        /// Constructor for the MaterialService class that initializes the instance with an object, implementing the IMaterialDataAccess interface, allowing access to the material data.
        /// </summary>
        public MaterialService(IMaterialDataAccess materialDataAccess)
        {
            _materialDataAccess = materialDataAccess;
        }

        /// <inheritdoc />
        public List<Material> GetAllMaterials()
        {
            var materialList = _materialDataAccess.GetAllMaterials();
            return materialList;
        }

        /// <inheritdoc />
        public Material AddMaterial(string name, int quantity)
        {
            var material = _materialDataAccess.CreateMaterial(name, quantity);
            return material;
        }

        /// <inheritdoc />
        public Material EditMaterialQuantity(int materialId, int newQuantity)
        {
            var material = _materialDataAccess.EditMaterialQuantity(materialId, newQuantity);
            return material;
        }
    }
}
