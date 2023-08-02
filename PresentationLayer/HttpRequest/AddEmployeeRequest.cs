namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    /// Class that saves the information to request an employeer registration.
    /// </summary>
    public class AddEmployeeRequest
    {
        /// <summary>
        /// String that holds the user's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// String that holds the user's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Employee's Role: 1 is adminitrator, 2 is ebanista, 3 is painter, 4 is tapizador, 5 is designer
        /// </summary>
        public int RoleId { get; set; }


    }
}
