using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI
{
    public sealed class PublisherCLIFramework
    {
        private string[] args;

        private PublisherCLIFramework()
        {
            this.Args = new string[] { };
        }

        public PublisherCLIFramework(string[] args) : this()
        {
            Args = args ?? throw new ArgumentNullException(nameof(args));
        }

        public string[] Args { get => args; private set => args = value; }

        public void Initialize()
        {
        }

        public void UpdateBlogs()
        {

        }

        public bool Execute()
        {
            return false;
        }
    }
}
