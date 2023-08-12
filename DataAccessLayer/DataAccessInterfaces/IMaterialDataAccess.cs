using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.ServiceInterfaces
{
    public interface IMaterialDataAccess
    {

        /// <summary>
        /// Lists all the Materials in record and their information
        /// </summary>
        /// <returns></returns>
        List<Material> GetAllMaterials();


        /// <summary>
        /// Creates a new Material record in the system with the provided details.
        /// </summary>
        /// <param name="name">Material's name</param>
        /// <param name="quantity">Material's quantity</param>
        /// <returns></returns>
        Material CreateMaterial(string name, int quantity);

        /// <summary>
        /// This method edits the quantity of an existing material
        /// </summary>
        /// <param name="materialId">Material's id</param>
        /// <param name="newQuantity">Material's quantity</param>
        /// <returns></returns>
        public Material EditMaterialQuantity(int materialId, int newQuantity);

        /// <summary>
        /// This method gets every material that is required for an specific product process
        /// </summary>
        /// <param name="productProcessId">The Identificator of a product process</param>
        /// <returns></returns>
        public List<Material> GetMaterialsRequiredByProductProcessId(int productProcessId);
    }
}
