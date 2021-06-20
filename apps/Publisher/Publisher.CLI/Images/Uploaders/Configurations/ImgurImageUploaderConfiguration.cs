using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publisher.CLI.Configuration;

namespace Publisher.CLI.Images.Uploaders.Configurations
{
    /// <summary>
    ///     
    /// </summary>
    public class ImgurImageUploaderConfiguration : ImageUploaderConfiguration
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private string clientId;

        /// <summary>
        ///     
        /// </summary>
        private string clientSecret; 
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string ClientId { get => clientId; set => clientId = value; }

        /// <summary>
        ///     
        /// </summary>
        public string ClientSecret { get => clientSecret; set => clientSecret = value; }
        #endregion
    }
}
