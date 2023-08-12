using Microsoft.EntityFrameworkCore;
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
    public class ToolService : IToolService
    {
        private IToolDataAccess _toolDataAccess;

        /// <summary>
        /// Constructor for the ToolService class that initializes the instance with an object, implementing the IToolDataAccess interface, allowing access to Tool data.
        /// </summary>
        public ToolService(IToolDataAccess toolDataAccess)
        {
            _toolDataAccess = toolDataAccess;
        }

        /// <inheritdoc />
        public List<Tool> GetAllTools()
        {
            var toollList = _toolDataAccess.GetAllTools();
            return toollList;
        }

        /// <inheritdoc />
        public Tool AddTool(string name, int quantity)
        {
            var tool = _toolDataAccess.CreateTool(name, quantity);
            return tool;
        }
    }
}
