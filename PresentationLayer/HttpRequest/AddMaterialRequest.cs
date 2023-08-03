namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    /// Class that saves the information to request a material registration.
    /// </summary>
    public class AddMaterialRequest
    {
        /// <summary>
        /// Material's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Material's quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
