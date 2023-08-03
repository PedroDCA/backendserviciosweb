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
        /// Creates a new Material record in the system with the provided details.
        /// </summary>
        /// <param name="name">Material's name</param>
        /// <param name="quantity">Material's quantity</param>
        /// <returns></returns>
        Material CreateMaterial(string name, int quantity);

        List<Material> GetAllMaterials();
    }
}
