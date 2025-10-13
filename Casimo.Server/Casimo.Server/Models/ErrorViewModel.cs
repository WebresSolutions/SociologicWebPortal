namespace Casimo.Server.Models
{
    /// <summary>
    /// View model for displaying error information to users
    /// Contains error details and controls the display of request identifiers
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the unique request identifier for tracking errors
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether to show the request ID
        /// Returns true when RequestId is not null or empty
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
