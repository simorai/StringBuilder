using System.Text;

namespace stringBuilder.Entities
{
    /// <summary>
    /// Representa um post em uma rede social ou blog.
    /// </summary>
    class Post
    {
        /// <summary>
        /// Obtém ou define o momento em que o post foi criado.
        /// </summary>
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        /// <summary>
        /// Obtém ou define a lista de comentários do post.
        /// A lista é inicializada como uma nova lista vazia na declaração.
        /// </summary>
        public List<Comment> Comments { get; set; } = new List<Comment>(); //for the list<Comment> to be instantiated.

        public Post() { } // default constructor without arguments

        /// <summary>
        /// Construtor para a classe Post.
        /// </summary>
        /// <param name="moment">A data e hora em que o post foi criado.</param>
        /// <param name="title">O título do post.</param>
        /// <param name="content">O conteúdo do post.</param>
        /// <param name="likes">O número inicial de likes do post.</param>
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment; // Inicializa a propriedade Moment com a data e hora fornecidas
            Title = title; // Define o título do post
            Content = content;  // Define o conteúdo do post
            Likes = likes; // Define o número inicial de likes
        }

        /// <summary>
        /// Adiciona um novo comentário à lista de comentários do post.
        /// </summary>
        /// <param name="comment">O objeto Comment a ser adicionado.</param>
        public void AddComment(Comment comment)
        {
            Comments.Add(comment); // Adiciona o comentário especificado à lista de comentários
        }

        /// <summary>
        /// Remove um comentário específico da lista de comentários do post.
        /// </summary>
        /// <param name="comment">O objeto Comment a ser removido.</param>
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment); // Remove o comentário especificado da lista de comentários
        }

        /// <summary>
        /// Sobrescreve o método ToString() para fornecer uma representação em string personalizada do objeto.
        /// </summary>
        /// <returns>Uma string formatada contendo informações detalhadas do objeto.</returns
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Cria um novo StringBuilder para construir a string de saída
            sb.AppendLine(Title); // Adiciona o título do post
            sb.Append(Likes); // Adiciona o número de likes
            sb.Append(" Likes - "); 
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));  // Adiciona a data e hora do post formatada
            sb.AppendLine(Content);  // Adiciona o conteúdo do post
            sb.AppendLine("Comments:"); // Adiciona um cabeçalho para os comentários
            foreach (Comment c in Comments) // Itera sobre todos os comentários e adiciona cada um
            {
                sb.AppendLine(c.ToString());
            }
            return sb.ToString(); // Retorna a string completa
        }
    }
}
