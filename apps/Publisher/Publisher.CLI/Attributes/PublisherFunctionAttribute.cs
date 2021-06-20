using System;

namespace Publisher.CLI.Attributes
{
    public sealed class PublisherFunctionAttribute
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private string iD;
        
        /// <summary>
        ///     
        /// </summary>
        private string name;
        
        /// <summary>
        ///     
        /// </summary>
        private string description; 
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public string ID { get => iD; set => iD = value; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        ///     
        /// </summary>
        public string Description { get => description; set => description = value; }
        #endregion

        #region Constructors
        /// <summary>
        ///     
        /// </summary>
        public PublisherFunctionAttribute()
        {
            ID = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public PublisherFunctionAttribute(string id, string name, string description) : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
        #endregion
    }
}
