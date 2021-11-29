using Publisher.CLI.Configuration;

namespace Publisher.CLI.Publishers.Configurations
{
    /// <summary>
    ///     
    /// </summary>
    public sealed class HashnodePublisherTargetConfiguration : PublisherTargetConfiguration
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private string personalAccessToken; 
        #endregion

        /// <summary>
        ///     The personal access token for authenticating with Hashnode
        /// </summary>
        public string PersonalAccessToken { get => personalAccessToken; set => personalAccessToken = value; }

        #region Constructors
        /// <summary>
        ///     
        /// </summary>
        public HashnodePublisherTargetConfiguration()
        {
        } 
        #endregion
    }
}
