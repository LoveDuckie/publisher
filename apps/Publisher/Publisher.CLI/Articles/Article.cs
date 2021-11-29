using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Articles
{
    public class Article
    {
        #region Fields
        private int id;
        private string title;
        private string summary;
        private string impressionURL;
        private ArticleContent content;
        private string slug; 
        #endregion

        #region Properties
        /// <summary>
        ///     The ID assigned to the article (primary key)
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        ///     The title
        /// </summary>
        public string Title { get => title; set => title = value; }

        /// <summary>
        ///     The summary
        /// </summary>
        public string Summary { get => summary; set => summary = value; }

        /// <summary>
        ///     The impression URL
        /// </summary>
        public string ImpressionURL { get => impressionURL; set => impressionURL = value; }

        /// <summary>
        ///     The slug
        /// </summary>
        public string Slug { get => slug; set => slug = value; }

        /// <summary>
        ///     
        /// </summary>
        public ArticleContent Content { get => content; set => content = value; }
        #endregion

        public void Load()
        {

        }
    }
}
