using ProductionBusinessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using ProductionDataAccessLayer.ServiceInterfaces;
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
        /// Constructor that initializes a new instance of the `ProcessService` class, it allows the `ProcessService` class to interact with the `IProcessService` object.
        /// </summary>
        public ProcessService(IProcessDataAccess processDataAccess)
        {
            _processDataAccess = processDataAccess;
        }
        public List<ProcessData> GetAllProcesses()
        {
            var processlList = _processDataAccess.GetAllProcesses();
            return processlList;
        }

        public Process AddProcess(string name, int toolId, int roleId)
        {
            var process = _processDataAccess.CreateProcess(name, toolId, roleId);
            return process;
        }
    }
}
