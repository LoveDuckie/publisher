using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Interfaces
{
    public interface IPublisher
    {
        PublisherOperation Publish(IPublisherContext context);
    }
}
