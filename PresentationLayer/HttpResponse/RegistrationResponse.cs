namespace ProductionPresentationLayer.HttpResponse
{
    public class RegistrationResponse
    {
        /// <summary>
        /// String that holds a message that indicates swhether the registration process was successful or not.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Integer that holds the new user's employee Id.
        /// </summary>
        public int EmployeeId { get; set; }
    }
}
