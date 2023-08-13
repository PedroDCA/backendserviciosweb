using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;

namespace ProductionDataAccessLayer.DataAccesses
{
    public class ProductProcessDataAccess : IProductProcessDataAccess
    {
        private readonly MySQLConnection _context;
        private readonly IMaterialDataAccess _materialDataAccess;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public ProductProcessDataAccess(MySQLConnection context, IMaterialDataAccess materialDataAccess)
        {
            _context = context;
            _materialDataAccess = materialDataAccess;
        }


        /// <inheritdoc />
        public ProductionPlanning GetProductionPlanningByProductId(int productId)
        {
            var product = _context.Product.FirstOrDefault(p => p.Id == productId);

            if (product == null)
            {
                // If the product with the provided name does not exist, you might want to throw an exception or handle it accordingly.
                throw new Exception("Error: Product does not exist.");
            }

            var productionProcesses = GetProductionProcessesByProductId(productId);

            var productionPlanning = new ProductionPlanning
            {
                ProductId = productId,
                ProductionProcesses = productionProcesses,
                ProductName = product.Name,
            };

            return productionPlanning;
        }

        /// <inheritdoc />
        public int GetRequiredMinutesForProductId(int productId)
        {
            var minutesRequiredList = _context.ProductProcess.Where((productProcess) => productProcess.ProductIdToCreate == productId).Select((productProcess) => productProcess.MinutesRequired);
            var totalMinutesRequired = minutesRequiredList.Aggregate((totalMinutesRequired, nextMinutesRequired) => totalMinutesRequired + nextMinutesRequired);

            return totalMinutesRequired;
        }

        /// <inheritdoc />
        public List<ProductProcessData> GetProductionProcessesByProductId(int productId)
        {
            var query =
                from pp in _context.ProductProcess
                join prd in _context.Product on pp.ProductIdToCreate equals prd.Id
                join p in _context.Process on pp.ProcessId equals p.Id
                join r in _context.Role on p.RoleId equals r.Id
                join rm in _context.RequiredMaterial on pp.Id equals rm.ProductProcessId
                join m in _context.Material on rm.MaterialId equals m.Id
                where pp.ProductIdToCreate == productId
                orderby pp.ProductionStep
                select new ProductProcessData
                {
                    Id = pp.Id,
                    Name = p.Name,
                    Role = new Role
                    {
                        Name = r.Name,
                        Id = r.Id,
                    },
                    MinutesRequired = pp.MinutesRequired
                };

            var result = query.ToList();

            foreach ( var process in result ) 
            {
                process.Materials = _materialDataAccess.GetMaterialsInformationByProductProcessId(process.Id);
            }

            return result;
        }

        /// <inheritdoc />
        public ProductProcess CreateProductProcess(int productId, int processId, int productionStep, int minutesRequired)
        {
            // Find the product with the given productName
            var product = _context.Product.FirstOrDefault(p => p.Id == productId);

            if (product == null)
            {
                // If the product with the provided name does not exist, you might want to throw an exception or handle it accordingly.
                throw new Exception("Error: Product does not exist.");
            }

            var productProcess = new ProductProcess()
            {
                ProductIdToCreate = product.Id, 
                ProcessId = processId,
                ProductionStep = productionStep,
                MinutesRequired = minutesRequired
            };

            _context.ProductProcess.Add(productProcess);
            _context.SaveChanges();

            return productProcess;
        }
    }
}
