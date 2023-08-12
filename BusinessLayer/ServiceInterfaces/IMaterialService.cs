using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    public interface IMaterialService
    {
        /// <summary>
        /// Method that returns a list of all the materials
        /// </summary>
        /// <returns></returns>
        List<Material> GetAllMaterials();

        /// <summary>
        /// Method declaration for adding a new Material with quantity
        /// </summary>
        /// <param name="name">Material's name</param>
        /// <param name="quantity">Material's quantity</param>
        /// <returns></returns>
        Material AddMaterial(string name, int quantity);

        /// <summary>
        /// Method to edit the quantity for a specific material
        /// </summary>
        /// <param name="materialId">Material's identification</param>
        /// <param name="newQuantity">Material's new  quantity</param>
        /// <returns></returns>
        public Material EditMaterialQuantity(int materialId, int newQuantity);
    }
}
