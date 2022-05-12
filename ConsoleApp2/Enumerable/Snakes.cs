using System;
using System.Collections;

namespace ConsoleApp2.Enumerable
{
    public class Snakes : IEnumerable, IEnumerator
    {
        private readonly Snake[] _snakes;

        private int position = -1;

        public Snakes(Snake[] pArray)
        {
            _snakes = new Snake[pArray.Length];

            for (var i = 0; i < pArray.Length; i++) _snakes[i] = pArray[i];
        }

        public Snake Current
        {
            get
            {
                try
                {
                    return _snakes[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            position++;
            return position < _snakes.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current => Current;

        public Snakes GetEnumerator()
        {
            return new Snakes(_snakes);
        }
    }
}