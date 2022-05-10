using System;

namespace ConsoleApp2
{
    public static class Snake
    {
        public static void Start()
        {
            var rnd = new Random();

            do
            {

                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft > 0)
                            Console.CursorLeft -= 1;
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 0)
                            Console.CursorTop -= 1;
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft < 100)
                            Console.CursorLeft += 1;
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < 100)
                            Console.CursorTop += 1;
                        break;
                }

                Color("@", (ConsoleColor)rnd.Next(0, 15));
                Console.CursorLeft -= 1;
            } while (true);
        }

        public static void Color(this string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
        }
    }
}