using ProductionDataAccessLayer.Classes;

namespace ProductionPresentationLayer.HttpRequest
{
    public class RequestedStepInformation
    {
        /// <summary>
        /// Gets or sets the process identifier.
        /// </summary>
        public int ProcessId { get; set; }

        /// <summary>
        /// Gets or sets the minutes required for the process.
        /// </summary>
        public int MinutesRequired { get; set; }

        /// <summary>
        /// Gets or sets the list of materials that will be used.
        /// </summary>
        public List<RequestedMaterial> Materials { get; set; }
    }
}
