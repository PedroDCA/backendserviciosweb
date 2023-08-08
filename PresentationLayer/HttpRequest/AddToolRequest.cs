namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    /// Class that saves the information to request a tool registration.
    /// </summary>
    public class AddToolRequest
    {
        /// <summary>
        /// Tool's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tool's quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
