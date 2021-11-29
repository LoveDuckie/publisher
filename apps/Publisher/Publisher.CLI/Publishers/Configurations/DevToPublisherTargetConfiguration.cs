using Publisher.CLI.Configuration;

namespace Publisher.CLI.Publishers.Configurations
{
    /// <summary>
    ///     
    /// </summary>
    public sealed class DevToPublisherTargetConfiguration : PublisherTargetConfiguration
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private string apiKey;
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string ApiKey { get => apiKey; set => apiKey = value; }
        #endregion

        public DevToPublisherTargetConfiguration()
        {
            ApiKey = string.Empty;
        }
    }
}
