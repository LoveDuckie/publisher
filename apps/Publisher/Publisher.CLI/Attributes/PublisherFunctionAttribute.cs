using System;

namespace Publisher.CLI.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class PublisherFunctionAttribute : Attribute
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private string id;
        
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
        ///     The ID of the function. This will be automatically generated if only the name and description is provided.
        /// </summary>
        public string Id { get => id; set => id = value; }

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
        ///     The base constructor
        /// </summary>
        public PublisherFunctionAttribute()
        {
            Id = string.Empty;
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
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
        #endregion
    }
}
