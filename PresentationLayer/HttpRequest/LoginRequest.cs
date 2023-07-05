namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    /// Class that represents a request for employee login, with an email and a password.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// String that holds the user's email address.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// String and holds the user's password.
        /// </summary>
        public string Password { get; set; }
    }
}
