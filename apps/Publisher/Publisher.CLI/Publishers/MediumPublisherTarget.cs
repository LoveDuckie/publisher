using Publisher.CLI.Interfaces;
using Publisher.CLI.Publishers.Configurations;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Publishers
{
    public sealed class MediumPublisherTarget : IPublisherTarget<MediumPublisherTargetConfiguration>
    {
        public MediumPublisherTargetConfiguration Configuration => throw new System.NotImplementedException();

        #region Methods
        /// <summary>
        ///     
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public PublisherOperation Publish(IPublisherContext context)
        {
            throw new System.NotImplementedException();
        } 
        #endregion
    }
}
