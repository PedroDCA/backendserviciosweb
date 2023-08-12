using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccesses
{
    /// <summary>
    /// Defines a class named ToolDataAccess that implements the IToolDataAcess interface.
    /// </summary>
    public class ToolDataAccess : IToolDataAccess
    {
        private readonly MySQLConnection _context;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public ToolDataAccess(MySQLConnection context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public List<Tool> GetAllTools()
        {
            List<Tool> result = _context.Tool.ToList();
            return result;
        }

        /// <inheritdoc />
        public Tool CreateTool(string name, int quantity)
        {
            var tool = new Tool()
            {
                Name = name,
                Quantity = quantity,
            };

            _context.Tool.Add(tool);
            _context.SaveChanges();

            return tool;
        }
    }
}
