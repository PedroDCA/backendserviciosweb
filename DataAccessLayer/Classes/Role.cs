using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.Classes
{
    public class Role
    {
        /// <summary>
        /// Role's identificator
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Role name defined: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer
        /// </summary>
        public string Name { get; set; }
    }
}
