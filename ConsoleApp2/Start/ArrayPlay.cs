using System;

namespace ConsoleApp2
{
    public static class ArrayPlay
    {
        private static void BubbleSortSimple(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            for (var j = 0; j < array.Length - 1; j++)
            {
                var tmp = array[j];
                if (array[j + 1] < tmp)
                {
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                }
            }
        }

        #region Pyramid

        private static void Pyramid(int size)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var num = 0;

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size - num; j++) Console.Write(" ");

                for (var k = 0; k <= i + num; k++) Console.Write("*");

                num++; //0

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Pyramid(int size, bool reversed)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var num = reversed ? size - 1 : 0;

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size - num; j++) Console.Write(" ");

                for (var k = 0; k <= (reversed ? size + num - i - 1 : i + num); k++) Console.Write("*");

                if (reversed)
                    num--;
                else
                    num++;

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        #endregion

        #region Array && Matrix

        private static int[,] Matrix(int size)
        {
            var matrix = new int[size, size];
            var rnd = new Random();

            for (var i = 0; i < size; i++)
            for (var j = 0; j < size; j++)
                matrix[i, j] = rnd.Next(10, 99);

            return matrix;
        }

        private static int[] Array(int size)
        {
            var array = new int[size];
            var rnd = new Random();

            for (var i = 0; i < size; i++) array[i] = rnd.Next(10, 99);

            return array;
        }

        private static void OutputArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++) Console.Write($"[{array[i]}] ");
        }

        private static void OutputMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(1); i++)
            {
                for (var j = 0; j < matrix.GetLength(0); j++) Console.Write($"[{matrix[i, j]}] ");

                Console.WriteLine("\n");
            }
        }

        #endregion
    }
}