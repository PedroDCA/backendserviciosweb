using Microsoft.AspNetCore.Mvc;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionPresentationLayer.HttpRequest;
using ProductionPresentationLayer.HttpResponse;

namespace ProductionPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessionController
    {
        private readonly ISessionService _sessionService;
        public SessionController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        [HttpPost("Login")]
        public LoginResponse AuthenticateEmployee([FromBody]LoginRequest loginRequest)
        {
            var isEmployeeAuthenticated = _sessionService.AuthenticateEmployee(loginRequest.Email, loginRequest.Password);
            var loginResponse = new LoginResponse()
            {
                Success = isEmployeeAuthenticated,
            };

            return loginResponse;
        }
    }
}
