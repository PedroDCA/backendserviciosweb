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

        /// <summary>
        /// This method returns a list of all the processes in record with their information
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// This method creates a new Process record with given values and returns it.
        /// </summary>
        /// <param name="name">Process' name</param>
        /// <param name="toolId">Tool's id used for the process</param>
        /// <param name="roleId">Role of the person needed to do the process</param>
        /// <returns></returns>
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
