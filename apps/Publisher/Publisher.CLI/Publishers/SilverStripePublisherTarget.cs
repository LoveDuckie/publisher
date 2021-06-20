using Publisher.CLI.Interfaces;
using Publisher.CLI.Publishers.Configurations;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Publishers
{
    public sealed class SilverStripePublisherTarget : IPublisherTarget<SilverStripePublisherTargetConfiguration>
    {
        public SilverStripePublisherTargetConfiguration Configuration => throw new System.NotImplementedException();

        public PublisherOperation Publish(IPublisherContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
