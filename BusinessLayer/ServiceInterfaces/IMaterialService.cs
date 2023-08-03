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
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        Material AddMaterial(string name, int quantity);
    }
}
