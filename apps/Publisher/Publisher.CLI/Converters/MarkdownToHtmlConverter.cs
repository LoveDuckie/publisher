using System;
using System.IO;

namespace Publisher.CLI.Converters
{
    /// <summary>
    ///     
    /// </summary>
    public sealed class MarkdownToHtmlConverter
    {
        /// <summary>
        ///     
        /// </summary>
        /// <param name="filePath">The absolute path to the file</param>
        public void LoadFromFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            	throw new ArgumentNullException(nameof(filePath), "The parameter \"filePath\" is invalid or null");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Failed: unable to find the file \"{filePath}\"", filePath);
            }

            string loadedContents = File.ReadAllText(filePath);
        }
    }
}
