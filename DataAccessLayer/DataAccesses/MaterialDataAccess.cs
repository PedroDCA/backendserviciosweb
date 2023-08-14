using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccesses
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

        /// <inheritdoc />
        public List<Material> GetAllMaterials()
        {
            List<Material> result = _context.Material.ToList();
            return result;
        }


        /// <inheritdoc />
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

        /// <inheritdoc />
        public Material EditMaterialQuantity(int materialId, int newQuantity)
        {
            // Retrieve the material from the database using the provided materialId
            var material = _context.Material.Find(materialId);

            if (material == null)
            {
                // If the material with the provided ID does not exist, it will throw an exception.
                throw new Exception("Error: Material does not exist.");
            }

            // Update the material's quantity with the new quantity
            material.Quantity = newQuantity;

            // Save the changes back to the database
            _context.SaveChanges();

            return material;
        }

        /// <inheritdoc />
        public List<Material> GetMaterialsInformationByProductProcessId(int productProcessId)
        {
            var query =
                from rm in _context.RequiredMaterial
                join pp in _context.ProductProcess on rm.ProductProcessId equals pp.Id
                join m in _context.Material on rm.MaterialId equals m.Id
                where pp.Id == productProcessId
                select new Material
                {
                    Id = rm.Id,
                    Name = m.Name,
                    Quantity = rm.Quantity
                };

            return query.ToList();

        }

        /// <inheritdoc />
        public RequiredMaterial CreateRequiredMaterialForProcess(int productProcessId, int materialId, int quantity)
        {
            var newRequiredMaterial = new RequiredMaterial
            {
                ProductProcessId = productProcessId,
                MaterialId = materialId,
                Quantity = quantity,
            };

            _context.RequiredMaterial.Add(newRequiredMaterial);
            _context.SaveChanges();

            return newRequiredMaterial;
        }

        /// <inheritdoc />
        public Material GetMaterialById(int materialId)
        {
            var material = _context.Material.FirstOrDefault(material => material.Id == materialId) ?? new Material();

            return material;
        }

        /// <inheritdoc />
        public List<RequiredMaterial> GetRequiredMaterialsByProductProcessId(int productProcessId)
        {
            var requiredMaterialList = _context.RequiredMaterial.Where((requiredMaterial) => requiredMaterial.ProductProcessId == productProcessId);

            return requiredMaterialList.ToList();
        }
    }
}
