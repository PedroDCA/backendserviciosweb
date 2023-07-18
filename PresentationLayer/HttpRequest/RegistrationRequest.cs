namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    /// Class that saves the information to request an employeer registration.
    /// </summary>
    public class RegistrationRequest
    {
        /// <summary>
        /// String that holds the user's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// String that holds the user's last name.
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// String that holds the user's email address.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// String that holds the user's password.
        /// </summary>
        public string Password { get; set; }
    }
}
