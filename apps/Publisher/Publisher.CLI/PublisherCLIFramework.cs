using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
        ///     
        /// </summary>
        public string Action { get => action; set => action = value; }

        /// <summary>
        ///     
        /// </summary>
        public string ConfigFilePath { get => configFilePath; set => configFilePath = value; } 
        #endregion
    }

    public sealed class PublisherCLIFramework
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private string[] args; 
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string[] Args { get => args; private set => args = value; } 
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
        public void InitializeProject()
        {
        }

        /// <summary>
        ///     
        /// </summary>
        public void UpdateBlogs()
        {

        }

        /// <summary>
        ///     
        /// </summary>
        public void NewBlog()
        {

        }

        public bool Execute()
        {
            return false;
        }
    }
}
