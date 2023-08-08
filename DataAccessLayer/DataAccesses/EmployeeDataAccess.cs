using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;

namespace ProductionDataAccessLayer.DataAccesses
{
    /// <summary>
    /// Defines a class named EmployeeDataAccess that implements the IEmployeeDataAccess interface.
    /// </summary>
    public class EmployeeDataAccess : IEmployeeDataAccess
    {

        private readonly MySQLConnection _context;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public EmployeeDataAccess(MySQLConnection context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public Employee GetEmployee (string email, string password)
        {
            // Fetch the employee with the given email and password from the Employee DbSet in the database
            Employee employee = _context.Employee.FirstOrDefault(employees => employees.Email == email && employees.Password == password);

            // If the employee with the given email and password is not found, return null or handle the error as needed
            return employee;
        }

        /// <inheritdoc />
        public Employee CreateEmployee(string name, string lastName, string email, string password, int roleId)
        {
            var employee = new Employee()
            {
                Id = 1,
                Name = name,
                LastName = lastName,
                Email = email,
                Password = password,
                RoleId = 1,
            };

            _context.Employee.Add(employee);
            _context.SaveChanges();

            return employee;
        }

        /// <inheritdoc />
        public List<Employee> GetAllEmployees()
        {
            List<Employee> result = _context.Employee.ToList();
            return result;
        }

        /// <inheritdoc />
        public PersonCharge SetPersonCharge(int productProcessId, int employeeId, int calendarId)
        {
            var personCharge = new PersonCharge()
            {
                ProductProcessId = productProcessId,
                EmployeeId = employeeId,
                CalendarId = calendarId
            };

            _context.PersonCharge.Add(personCharge);
            _context.SaveChanges();

            return personCharge;
        }
    }
}
