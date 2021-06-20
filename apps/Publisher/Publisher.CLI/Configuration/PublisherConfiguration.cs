using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Configuration
{
    public class PublisherConfiguration
    {
        private string GetDefaultBlogsPath()
        {
            return string.Empty;
        }

        public string BlogsPath { get; set; }
    }
}
