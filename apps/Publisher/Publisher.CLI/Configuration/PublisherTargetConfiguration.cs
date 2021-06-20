using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Configuration
{
    public class PublisherTargetConfiguration
    {
        public string PublisherTargetType { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        public PublisherTargetConfiguration()
        {
            Properties = new Dictionary<string, string>();
            PublisherTargetType = string.Empty;
        }
    }
}
