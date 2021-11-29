using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Publisher.CLI.Attributes;

namespace Publisher.CLI
{
    public class PublisherCLIFrameworkOptions
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private List<string> extensionsPaths;
        
        /// <summary>
        /// 
        /// </summary>
        private string configFilePath;

        /// <summary>
        /// 
        /// </summary>
        private string action; 
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public List<string> ExtensionsPaths { get => extensionsPaths; set => extensionsPaths = value; }

        /// <summary>
        ///     The action
        /// </summary>
        public string Action { get => action; set => action = value; }

        /// <summary>
        ///     The absolute path to the configuration file.
        /// </summary>
        public string ConfigFilePath { get => configFilePath; set => configFilePath = value; }

        /// <summary>
        ///     The absolute path to the project we are working from
        /// </summary>
        public string ProjectPath { get; set; }
        #endregion

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        private string GetDefaultProjectPath()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"project");
        }
    }

    /// <summary>
    ///     
    /// </summary>
    public sealed partial class PublisherCLIFramework
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private string[] args;

        /// <summary>
        /// 
        /// </summary>
        private PublisherCLIFrameworkOptions options;
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string[] Args { get => args; private set => args = value; }

        /// <summary>
        ///     
        /// </summary>
        public PublisherCLIFrameworkOptions Options { get => options; set => options = value; }
        #endregion

        #region Constructors
        /// <summary>
        ///     
        /// </summary>
        private PublisherCLIFramework()
        {
            this.Args = new string[] { };
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="args"></param>
        public PublisherCLIFramework(string[] args) : this()
        {
            Args = args ?? throw new ArgumentNullException(nameof(args));
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetAvailableFunctionNames()
        {
            return this.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance).Select(n => n.Name).ToList();
        }

        /// <summary>
        ///     
        /// </summary>
        [PublisherFunction(Id = "init")]
        public void InitializeProject()
        {
        }

        /// <summary>
        ///     
        /// </summary>
        [PublisherFunction(Id = "update-blogs")]
        public void UpdateBlogs()
        {

        }

        /// <summary>
        ///     
        /// </summary>
        [PublisherFunction(Id = "new-blog")]
        public void NewBlog()
        {

        }

        /// <summary>
        ///     
        /// </summary>
        [PublisherFunction(Id = "update-blog")]
        public void UpdateBlog()
        {

        }

        /// <summary>
        ///     
        /// </summary>
        [PublisherFunction(Id = "delete-blog")]
        public void DeleteBlog()
        {
            
        }

        /// <summary>
        ///     
        /// </summary>
        [PublisherFunction(Id = "publish-blog")]
        public void PublishBlog()
        {
            
        }

        /// <summary>
        ///     Execute the framework
        /// </summary>
        /// <returns></returns>
        public bool Execute()
        {
            return false;
        }
    }
}
