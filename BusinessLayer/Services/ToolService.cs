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
        /// Constructor that initializes a new instance of the `ToolService` class, it allows the `ToolService` class to interact with the `ToolService` object.
        /// </summary>
        public ToolService(IToolDataAccess toolDataAccess)
        {
            _toolDataAccess = toolDataAccess;
        }

        public List<Tool> GetAllTools()
        {
            var toollList = _toolDataAccess.GetAllTools();
            return toollList;
        }

        public Tool AddTool(string name, int quantity)
        {
            var tool = _toolDataAccess.CreateTool(name, quantity);
            return tool;
        }
    }
}
