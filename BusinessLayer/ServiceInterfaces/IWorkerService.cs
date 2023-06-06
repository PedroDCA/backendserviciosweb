using ProductionBusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Interfaces
{
    /// <summary>
    /// Relates to every transaccion that is exclusively for the worker context.
    /// It could relate to its position, basic information, etc.
    /// </summary>
    public interface IWorkerService
    {
        /// <summary>
        /// Gets the basic information of each active worker.
        /// </summary>
        /// <returns>A list of the basic information for each active worker.</returns>
        IList<BasicWorkerInformation> GetBasicActiveWorkerInformation();
    }
}
