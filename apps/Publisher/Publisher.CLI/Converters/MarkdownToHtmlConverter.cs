using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Converters
{
    public class MarkdownToHtmlConverter
    {
        public void LoadFromFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            	throw new ArgumentNullException(nameof(filePath), "The parameter \"filePath\" is invalid or null");

            if (!File.Exists(filePath))
            {

            }
        }
    }
}
