using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionBusinessLayer.Services;
using ProductionDataAccessLayer.Classes;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController
    {
        //Contructor used to inject the IEmployeeService interface
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // HTTP GET action to get all employees information
        [HttpGet("GetAll")]
        public List<Employee> GetAllEmployeesInformation()
        {
            List<Employee> employeesInformation = _employeeService.GetAllEmployees();

            return employeesInformation;
        }

        // HTTP POST action to add an employee
        [HttpPost("AddEmployee")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] AddEmployeeRequest request)
        {
            // Extract registration data from the HTTP request
            string name = request.Name;
            string lastName = request.LastName;
            int roleId = request.RoleId ;

            // Call the registration service to register the employee
            var newEmployee = _employeeService.AddEmployee(name, lastName, roleId);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Employee added successfully",
                EmployeeId = newEmployee.Id,
            };

            return response;

        }
    }
}
