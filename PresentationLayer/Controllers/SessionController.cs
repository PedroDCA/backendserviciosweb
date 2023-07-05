using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
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
    }
}
