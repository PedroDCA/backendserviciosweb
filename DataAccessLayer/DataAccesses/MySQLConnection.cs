using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using ProductionDataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccesses
{
    public class MySQLConnection : DbContext
    {
        public MySQLConnection(DbContextOptions<MySQLConnection> options) : base(options)
        {

        }

        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<PersonCharge> PersonCharge { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Process> Process { get; set; }
        public DbSet<ProductProcess> ProductProcess { get; set; }
        public DbSet<RequiredMaterial> RequiredMaterial { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Tool> Tool { get; set; }

    }
}
