using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.ServiceInterfaces
{
    public interface IProcessService
    {
        /// <summary>
        /// Method that returns a list of all the Processes
        /// </summary>
        /// <returns></returns>
        public List<ProcessData> GetAllProcesses();

        /// <summary>
        /// Method declaration for adding a new Process with quantity
        /// </summary>
        /// <param name="name">Process' name</param>
        /// <param name="toolId">Tool's id used for the process</param>
        /// <param name="roleId">Role of the person needed to do the process</param>
        /// <returns></returns>
        public Process AddProcess(string name, int toolId, int roleId);
    }
}
