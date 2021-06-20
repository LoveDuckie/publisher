using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /// <summary>
        ///     Upload the image.
        /// </summary>
        /// <param name="imageFilePath">The absolute path to the image to upload</param>
        /// <returns></returns>
        public override PublisherOperation UploadImage(string imageFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
