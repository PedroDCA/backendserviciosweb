namespace ProductionPresentationLayer.HttpRequest
{
    /// <summary>
    /// Class that saves the information to request a material's quantity update.
    /// </summary>
    public class EditMaterialRequest
    {
        /// <summary>
        /// Material's identification
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Material's quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
