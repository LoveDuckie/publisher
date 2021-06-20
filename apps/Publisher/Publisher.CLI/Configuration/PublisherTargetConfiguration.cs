using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Configuration
{
    public class PublisherTargetConfiguration
    {
        private string publisherTargetType;
        private Dictionary<string, string> properties;
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
