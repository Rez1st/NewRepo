using System;

namespace ConsoleApp2
{
    /// <summary>
    /// This is any custom exception
    /// </summary>
    public class YouShallNotPassException : Exception
    {
        public YouShallNotPassException(string message) : base(message) // : base(message) вызов конструктора базового класса
        {
        }

        public YouShallNotPassException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}