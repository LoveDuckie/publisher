using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publisher.CLI.Configuration;

namespace Publisher.CLI.Publishers.Configurations
{
    public sealed class DevToPublisherTargetConfiguration : PublisherTargetConfiguration
    {
        public string ApiKey { get; set; }

        public DevToPublisherTargetConfiguration()
        {
            ApiKey = string.Empty;
        }
    }
}
