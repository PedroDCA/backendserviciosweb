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
    /// Defines a class named ProcessDataAccess that implements the IProcessDataAccess interface.
    /// </summary>
    public class ProcessDataAccess : IProcessDataAccess
    {
        private readonly MySQLConnection _context;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public ProcessDataAccess(MySQLConnection context)
        {

            _context = context;
        }

        /// <inheritdoc />
        public List<ProcessData> GetAllProcesses()
        {
            var query =
                from p in _context.Process
                join t in _context.Tool on p.ToolId equals t.Id
                join r in _context.Role on p.RoleId equals r.Id
                select new ProcessData
                {
                    Name = p.Name,
                    Tool = new Tool
                    {
                        Id = p.ToolId,
                        Name = t.Name
                    },

                    Role = new Role
                    {

                        Id = p.RoleId,
                        Name = r.Name
                    }
                };

            return query.ToList();
        }

        /// <inheritdoc />
        public Process CreateProcess(string name, int toolId, int roleId)
        {
            var process = new Process()
            {
                Name = name,
                ToolId = toolId,
                RoleId = roleId,
            };

            _context.Process.Add(process);
            _context.SaveChanges();

            return process;
        }
    }
}
