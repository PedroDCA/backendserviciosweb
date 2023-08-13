namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    ///  Class that saves the information to request a product registration.
    /// </summary>
    public class AddProductRequest
    {
        /// <summary>
        /// Products's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The steps that are required for the product.
        /// </summary>
        public List<RequestedStepInformation> Steps { get; set; }
    }
}
