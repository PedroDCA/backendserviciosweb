namespace ProductionDataAccessLayer.Classes
{
    public class RequestedMaterial
    {
        /// <summary>
        /// Material identifier that will be required.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The material quantity required for the production.
        /// </summary>
        public int Quantity { get; set; }
    }
}
