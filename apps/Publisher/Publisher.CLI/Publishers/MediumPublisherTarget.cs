﻿using Publisher.CLI.Interfaces;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Publishers
{
    public sealed class MediumPublisherTarget : IPublisher
    {
        public PublisherOperation Publish(IPublisherContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
