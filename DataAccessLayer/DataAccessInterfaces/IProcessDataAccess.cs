using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccessInterfaces
{
    public interface IProcessDataAccess
    {
        /// <summary>
        /// Creates a new Process record in the system with the provided details.
        /// </summary>
        /// <param name="name">Process' name</param>
        /// <param name="toolId">Tool's id used for the process</param>
        /// <param name="roleId">Role of the person needed to do the process</param>
        /// <returns></returns>
        Process CreateProcess(string name, int toolId, int roleId);

        /// <summary>
        /// Lists all the Processes in record and their information
        /// </summary>
        /// <returns></returns>
        List<Process> GetAllBaseInformationProcesses();
    }
}
