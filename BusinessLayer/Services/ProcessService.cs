using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Services
{
    public class ProcessService : IProcessService
    {
        private IProcessDataAccess _processDataAccess;
        /// <summary>
        /// Constructor for the ProcessService class that initializes the instance with an object, implementing the IProcessDataAccess interface, allowing access to process data.
        /// </summary>
        public ProcessService(IProcessDataAccess processDataAccess)
        {
            _processDataAccess = processDataAccess;
        }

        /// <inheritdoc />
        public List<ProcessData> GetAllProcesses()
        {
            var processlList = _processDataAccess.GetAllProcesses();
            return processlList;
        }

        /// <inheritdoc />
        public Process AddProcess(string name, int toolId, int roleId)
        {
            var process = _processDataAccess.CreateProcess(name, toolId, roleId);
            return process;
        }
    }
}
