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

        /// <summary>
        ///     
        /// </summary>
        private string taskName;
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string TargetURL { get => targetURL; set => targetURL = value; }

        /// <summary>
        ///     
        /// </summary>
        public string TaskName { get => taskName; set => taskName = value; }
        #endregion

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        public bool IsTargetURLValid()
        {
            return false;
        }

        private string GetDevTaskURL()
        {
            return string.Empty;
        }

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
