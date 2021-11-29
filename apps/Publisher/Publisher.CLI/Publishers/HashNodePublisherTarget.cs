using System;
using Publisher.CLI.Interfaces;
using Publisher.CLI.Publishers.Configurations;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Publishers
{
    /// <summary>
    ///     
    /// </summary>
    public sealed class HashnodePublisherTarget : IPublisherTarget<HashnodePublisherTargetConfiguration>
    {
        /// <summary>
        ///     
        /// </summary>
        private HashnodePublisherTargetConfiguration configuration;

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public HashnodePublisherTargetConfiguration Configuration { get => configuration; private set => configuration = value; }
        #endregion

        /// <summary>
        ///     
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public PublisherOperation Publish(IPublisherContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            return null;
        }
    }
}
