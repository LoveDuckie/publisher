using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Publisher.CLI.Utility
{
    public static class SQLiteUtility
    {
        /// <summary>
        ///     Create a new database in the path specified
        /// </summary>
        /// <param name="filePath"></param>
        public static void CreateNewDatabase(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            	throw new ArgumentNullException(nameof(filePath), "The parameter \"filePath\" is invalid or null");

            
        }
    }
}
