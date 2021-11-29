using System;
using Publisher.CLI.Images.Uploaders.Configurations;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Images.Uploaders
{
    /// <summary>
    ///     
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ImageUploader<T> where T : ImgurImageUploaderConfiguration, new()
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private T configuration; 
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public T Configuration { get => configuration; private set => configuration = value; } 
        #endregion

        /// <summary>
        ///     
        /// </summary>
        /// <param name="imageFilePath">The absolute path to the image that we are to upload</param>
        /// <returns></returns>
        public PublisherOperation UploadImage(string imageFilePath)
        {
            if (string.IsNullOrEmpty(imageFilePath))
            	throw new ArgumentNullException(nameof(imageFilePath), "The parameter \"imageFilePath\" is invalid or null");

            return null;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="imageFilePath"></param>
        protected abstract void OnUploadImage(string imageFilePath);
    }
}
