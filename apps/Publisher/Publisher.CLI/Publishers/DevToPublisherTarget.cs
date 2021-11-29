using System;
using Publisher.CLI.Interfaces;
using Publisher.CLI.Publishers.Configurations;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Publishers
{
    /// <summary>
    ///     
    /// </summary>
    public sealed class DevToPublisherTarget : IPublisherTarget<DevToPublisherTargetConfiguration>
    {
        #region Properties
        /// <summary>
        ///     The configuration
        /// </summary>
        public DevToPublisherTargetConfiguration Configuration => throw new System.NotImplementedException();
        #endregion

        #region Methods
        /// <summary>
        ///     
        /// </summary>
        /// <param name="context">The context</param>
        /// <returns>Returns the generated operation</returns>
        public PublisherOperation Publish(IPublisherContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            return null;
        } 
        #endregion
    }
}
