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

        /// <summary>
        /// This method returns a list of all the Tools in record with their information
        /// </summary>
        /// <returns></returns>
        public List<Tool> GetAllTools()
        {
            List<Tool> result = _context.Tool.ToList();
            return result;
        }


        /// <summary>
        /// This method creates a new Tool record with given values and returns it. 
        /// </summary>
        /// <param name="name">Tool's name</param>
        /// <param name="quantity">Tool's quantity</param>
        /// <returns></returns>
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
