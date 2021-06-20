using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publisher.CLI.Configuration;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Interfaces
{
    public interface IPublisherTarget<T> where T : PublisherTargetConfiguration, new()
    {
        /// <summary>
        ///     The configuration used for this target
        /// </summary>
        T Configuration { get; }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        PublisherOperation Publish(IPublisherContext context);
    }
}
