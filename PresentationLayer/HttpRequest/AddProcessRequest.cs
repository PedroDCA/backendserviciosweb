namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    /// Class that saves the information to request a process registration.
    /// </summary>
    public class AddProcessRequest
    {
        /// <summary>
        /// Process' name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tool's id used for the process
        /// </summary>
        public int ToolId { get; set; }

        /// <summary>
        /// Role of the person needed to do the process
        /// </summary>
        public int RoleId { get; set; }
    }
}
