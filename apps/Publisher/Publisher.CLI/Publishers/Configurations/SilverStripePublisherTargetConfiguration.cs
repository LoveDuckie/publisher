using Publisher.CLI.Configuration;

namespace Publisher.CLI.Publishers.Configurations
{
    public sealed class SilverStripePublisherTargetConfiguration : PublisherTargetConfiguration
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private string targetURL;
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string TargetURL { get => targetURL; set => targetURL = value; } 
        #endregion

        #region Constructors
        /// <summary>
        ///     
        /// </summary>
        public SilverStripePublisherTargetConfiguration()
        {
        } 
        #endregion
    }
}
