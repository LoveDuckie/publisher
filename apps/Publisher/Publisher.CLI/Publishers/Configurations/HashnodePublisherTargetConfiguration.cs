using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publisher.CLI.Configuration;

namespace Publisher.CLI.Publishers.Configurations
{
    public sealed class HashnodePublisherTargetConfiguration : PublisherTargetConfiguration
    {
        /// <summary>
        ///     The personal access token for authenticating with Hashnode
        /// </summary>
        public string PersonalAccessToken { get; set; }

        /// <summary>
        ///     
        /// </summary>
        public HashnodePublisherTargetConfiguration()
        {
        }
    }
}
