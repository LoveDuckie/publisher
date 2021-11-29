using System.Collections.Generic;

namespace Publisher.CLI.Configuration
{
    public abstract class PublisherTargetConfiguration
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private string publisherTargetType;

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, string> properties; 
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string PublisherTargetType { get => publisherTargetType; private set => publisherTargetType = value; }

        /// <summary>
        ///     
        /// </summary>
        public Dictionary<string, string> Properties { get => properties; private set => properties = value; }
        #endregion

        #region Constructors
        /// <summary>
        ///     
        /// </summary>
        public PublisherTargetConfiguration()
        {
            Properties = new Dictionary<string, string>();
            PublisherTargetType = string.Empty;
        }
        #endregion
    }
}
