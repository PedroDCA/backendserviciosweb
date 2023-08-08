using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    public interface IToolService
    {
        /// <summary>
        /// Lists all the Tools in record and their information
        /// </summary>
        /// <returns></returns>
        public List<Tool> GetAllTools();

        /// <summary>
        /// Creates a new Tool record in the system with the provided details.
        /// </summary>
        /// <param name="name">Tool's name</param>
        /// <param name="quantity">Tool's quantity</param>
        /// <returns></returns>
        public Tool AddTool(string name, int quantity);
    }
}
