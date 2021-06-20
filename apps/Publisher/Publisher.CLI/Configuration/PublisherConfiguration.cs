using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Configuration
{
    public sealed class PublisherConfiguration
    {
        #region Constants
        /// <summary>
        ///     
        /// </summary>
        private const string DefaultPublisherConfigurationPathName = ".publisher";

        /// <summary>
        ///     
        /// 
        /// </summary>
        private const string DefaultPublisherBlogsPathName = "blogs"; 
        #endregion

        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private string blogsPath; 
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string BlogsPath { get => blogsPath; set => blogsPath = value; }
        #endregion

        #region Constructors
        /// <summary>
        ///     The base constructor
        /// </summary>
        public PublisherConfiguration()
        {
            BlogsPath = string.Empty;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="blogsPath">The absolute path to where the blogs markdown are to be stored.</param>
        public PublisherConfiguration(string blogsPath) : this()
        {
            BlogsPath = blogsPath ?? throw new ArgumentNullException(nameof(blogsPath));
        } 
        #endregion

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        private string GetDefaultBlogsPath()
        {

            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "blogs");
        }

        private string GetDefaultPublisherConfigsPath()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ".publisher");
        }
    }
}
