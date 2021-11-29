using System;
using Publisher.CLI.Images.Uploaders.Configurations;
using Publisher.CLI.Threading;

namespace Publisher.CLI.Images.Uploaders
{
    /// <summary>
    ///     For uploading images to imgur.com
    /// </summary>
    public sealed class ImgurImageUploader : ImageUploader<ImgurImageUploaderConfiguration>
    {
        /// <summary>
        ///     The base constructor
        /// </summary>
        public ImgurImageUploader()
        {
        }


        protected override void OnUploadImage(string imageFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
