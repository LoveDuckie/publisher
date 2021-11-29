using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Images.Compression
{
    /// <summary>
    ///     
    /// </summary>
    public abstract class ImageCompressor
    {

        public abstract void OnCompress(string imageFilePath);
    
    }
}
