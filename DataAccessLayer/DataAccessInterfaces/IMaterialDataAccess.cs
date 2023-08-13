using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccessInterfaces
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
        /// This method gets every material information that is required for an specific product process
        /// </summary>
        /// <param name="productProcessId">The Identificator of a product process</param>
        /// <returns></returns>
        public List<Material> GetMaterialsInformationByProductProcessId(int productProcessId);

        /// <summary>
        /// Set a new required material for the process specified.
        /// </summary>
        /// <param name="productProcessId">Product Process identifier.</param>
        /// <param name="materialId">Material identifier.</param>
        /// <param name="quantity">Required quantity.</param>
        /// <returns>The required material information created.</returns>
        public RequiredMaterial CreateRequiredMaterialForProcess(int productProcessId, int materialId, int quantity);

        /// <summary>
        /// Gets the material information by its id.
        /// </summary>
        /// <param name="materialId">Material identifier.</param>
        /// <returns>The material information.</returns>
        public Material GetMaterialById(int materialId);

        /// <summary>
        /// Gets the base information about the required material that will be used on the product process.
        /// </summary>
        /// <param name="productProcessId">The product process identifier.</param>
        /// <returns>The base information list about the required materials.</returns>
        public List<RequiredMaterial> GetRequiredMaterialsByProductProcessId(int productProcessId);
    }
}
