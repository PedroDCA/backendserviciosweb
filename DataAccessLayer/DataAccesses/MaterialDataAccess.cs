﻿using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.ServiceInterfaces;
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
        /// This method creates a new Material record with given values and returns it. 
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

        /// <summary>
        /// This method edits the quantity of an existing material
        /// </summary>
        /// <param name="materialId">Material's id</param>
        /// <param name="newQuantity">Material's quantity</param>
        /// <returns></returns>
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

        public List<Material> GetMaterialsRequiredByProductProcessId(int productProcessId)
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

    }
}
