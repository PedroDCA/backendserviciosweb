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
        public DbSet<Process> Process { get; set; }
        public DbSet<ProductProcess> ProductProcess { get; set; }
        public DbSet<RequiredMaterial> RequiredMaterial { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Tool> Tool { get; set; }


        /*
        private readonly MySqlConnectionStringBuilder _mySQLConnectionStringBuilder;
        public MySQLConnection()
        {
            _mySQLConnectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "serviciosweb.mysql.database.azure.com",
                Database = "Integration",
                UserID = "serviciosweb",
                Password = "hola1234@",
                SslMode = MySqlSslMode.Required,
            };
        }

        public async T GetInformation<T>(List<string>properties, string table)
        {
            var formattedProperties = properties.Any()? string.Join(",", properties):"*";

            using (var connection = new MySqlConnection(_mySQLConnectionStringBuilder.ConnectionString))
            {
                Console.WriteLine("Opening connection");
                await connection.OpenAsync();
                using (var command = connection.CreateCommand())
                {
                    
                    command.CommandText = @"SELECT @properties FROM @table;";
                    command.Parameters.AddWithValue("@properties", formattedProperties);
                    command.Parameters.AddWithValue("@table", table);
                    int rowCount = await command.;
                    

                }
                // connection will be closed by the 'using' block

                Console.WriteLine("Closing connection");

            }
        }

        public async T CreateInformation<T>()
        {
            using (var connection = new MySqlConnection(_mySQLConnectionStringBuilder.ConnectionString))
            {
                Console.WriteLine("Opening connection");
                await connection.OpenAsync();
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = @"INSERT INTO inventory (name, quantity) VALUES (@name1, @quantity1), (@name2, @quantity2), (@name3, @quantity3);";
                    command.Parameters.AddWithValue("@name1", "banana");
                    command.Parameters.AddWithValue("@quantity1", 150);
                    command.Parameters.AddWithValue("@name2", "orange");
                    command.Parameters.AddWithValue("@quantity2", 154);
                    command.Parameters.AddWithValue("@name3", "apple");
                    command.Parameters.AddWithValue("@quantity3", 100);
                    int rowCount = await command.ExecuteNonQueryAsync();
                    Console.WriteLine(String.Format("Number of rows inserted={0}", rowCount));

                }
                // connection will be closed by the 'using' block

                Console.WriteLine("Closing connection");

            }
        }
        */
    }
}
