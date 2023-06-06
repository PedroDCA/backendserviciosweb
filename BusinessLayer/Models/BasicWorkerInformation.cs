using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionBusinessLayer.Models
{
    public class BasicWorkerInformation
    {
        /// <summary>
        /// Gets or sets the name of the worker.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the job of the worker.
        /// </summary>
        /// <example>
        /// Painter / Pintor
        /// </example>
        public string Job { get;set; }

    }
}
