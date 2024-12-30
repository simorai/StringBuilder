namespace stringBuilder.Entities
{
    /// <summary>
    /// Representa um comentário associado a um post.
    /// </summary>
    class Comment
    {
        /// <summary>
        /// Obtém ou define o texto do comentário.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Construtor padrão para a classe Comment.
        /// </summary>
        public Comment() { }

        /// <summary>
        /// Construtor que inicializa um novo comentário com um texto específico.
        /// </summary>
        /// <param name="text">O texto do comentário.</param>
        public Comment(string text)
        {
            Text = text;
        }
    }
}
