namespace Jogo.Velha
{
    /// <summary>
    /// Exceção lançada quando ocorre algum problema na jogada feita pelo jogador.
    /// </summary>
    internal class PlayException : Exception
    {
        /// <summary>
        /// Construtor.
        /// </summary>
        public PlayException()
        {
        }

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="message">Mensagem de exceção.</param>
        public PlayException(string? message)
            : base(message)
        {
        }
        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="message">Mensagem de exceção.</param>
        /// <param name="innerException">Exceção aninhada.</param>
        public PlayException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
