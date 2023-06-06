using ProductionBusinessLayer.Interfaces;
using ProductionBusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Classes
{
    /// <inheritdoc/>
    public class WorkerService : IWorkerService
    {
        /// <inheritdoc/>
        public IList<BasicWorkerInformation> GetBasicActiveWorkerInformation()
        {
            // TODO: Implement a new service on Data Access Layer to get the list of current workers.
            var workerInformationList = new List<BasicWorkerInformation>()
            {
                new BasicWorkerInformation()
                {
                    Name = "Pedro",
                    Job = "Painter",
                },

                new BasicWorkerInformation()
                {
                    Name = "Juan",
                    Job = "Designer",
                },

                new BasicWorkerInformation()
                {
                    Name = "Carolina",
                    Job = "Upholsterer",
                },
            };

            return workerInformationList;
        }
    }
}
