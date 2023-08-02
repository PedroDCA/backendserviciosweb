namespace ProductionPresentationLayer.HttpResponse
{
    public class RegistrationResponse
    {
        /// <summary>
        /// String that holds a message that indicates swhether the registration process was successful or not.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Integer that holds the Id.
        /// </summary>
        public int Id { get; set; }
    }
}
