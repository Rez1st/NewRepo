using System;

namespace ConsoleApp2.Enumerable
{
    public class Snake
    {
        private readonly int _length;
        private readonly char _pattern;
        private byte _color;

        public Snake(char pattern, int length, byte color = 0)
        {
            _pattern = pattern;
            _length = length;
            _color = color;
        }

        /// <summary>
        ///     Set a snake color, value is equal or bigger then 0 and less or equal 15
        /// </summary>
        /// <exception cref="InvalidOperationException">Refer to Console color enum</exception>
        public byte Color
        {
            get => _color;
            set
            {
                if (value is >= 0 and < 16) // pattern (value > 0 && value < 16)
                    _color = value;
                else
                    throw new InvalidOperationException("Value should be between 0 and 15");
            }
        }

        public void Appear()
        {
            Console.ForegroundColor = (ConsoleColor) _color;
            for (var i = 0; i < _length; i++) Console.Write(_pattern);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}