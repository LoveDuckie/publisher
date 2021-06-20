using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public T Configuration { get; private set; }

        public abstract PublisherOperation UploadImage(string imageFilePath);
    }
}
