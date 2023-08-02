using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionBusinessLayer.Services;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;
using static System.Net.WebRequestMethods;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // Controller that handles HTTP requests related to user sessions.
    public class SessionController
    {
        //Contructor used to inject the ISessionService interface
        private readonly ISessionService _sessionService;

        public SessionController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        // HTTP POST action to authenticate an employee
        [HttpPost("Login")]
        public LoginResponse AuthenticateEmployee([FromBody] LoginRequest loginRequest)
        {
            //Authenticate the employee using the ISessionService
            var isEmployeeAuthenticated = _sessionService.AuthenticateEmployee(loginRequest.Email, loginRequest.Password);

            // Create a LoginResponse object based on the authentication result
            var loginResponse = new LoginResponse()
            {
                Success = isEmployeeAuthenticated,
            };

            // Return the LoginResponse as the HTTP response
            return loginResponse;
        }

        // HTTP POST action to register an employee
        [HttpPost("Registration")]
        public RegistrationResponse HandleRegistrationRequest([FromBody] RegistrationRequest request)
        {
            // Extract registration data from the HTTP request
            string name = request.Name;
            string lastName = request.LastName;
            string email = request.Email;
            string password = request.Password;

            // Call the registration service to register the employee
            var newEmployee = _sessionService.RegisterEmployee(name, lastName, email, password, 1);

            // Generate an HTTP response indicating successful registration
            RegistrationResponse response = new RegistrationResponse
            {
                Message = "Registration successful",
                Id = newEmployee.Id,
            };

            return response;

        }
    }


}
