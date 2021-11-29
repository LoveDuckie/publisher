namespace Publisher.CLI.Articles
{
    public sealed class ArticlePublished
    {
        #region Fields
        /// <summary>
        ///     
        /// </summary>
        private Article parentArticle;

        /// <summary>
        ///     
        /// </summary>
        private int id;
        #endregion

        #region Properties
        /// <summary>
        ///     
        /// </summary>
        public Article ParentArticle { get => parentArticle; set => parentArticle = value; }

        /// <summary>
        ///     
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        ///     
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///     
        /// </summary>
        public string URL { get; set; }
        #endregion
    }
}
