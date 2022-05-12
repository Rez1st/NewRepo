using System;

namespace ConsoleApp2
{
    internal static class Store
    {
        #region Store

        public static void Start()
        {
            var goods = new string[5] {"Mage Wound", "Mage Hat", "Mage Dress", "Taro Cards", "Magic Box"};
            var prices = new double[5] {13.99, 99.99, 17.44, 49.99, 99.99};
            var quantity = new int[5];
            bool exit = default;
            double fullPrice = 0;
            var lastItem = byte.MaxValue;

            do
            {
                Console.WriteLine("| Press [ exit ] for complete exit from store");
                Console.WriteLine("| Press [ buy ] to purchase all goods");

                for (var i = 0; i < goods.Length; i++)
                    Console.WriteLine($"| Press [{i}] to select. Cost:[{prices[i]}] for {goods[i]}");

                Console.SetCursorPosition(0, 20);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Total amount: {fullPrice}");
                Console.ResetColor();
                Console.SetCursorPosition(0, 8);

                if (lastItem != byte.MaxValue)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"You just added {goods[lastItem]} for {prices[lastItem]}");
                    Console.ResetColor();
                    Console.WriteLine("Would you like to add more?");
                }

                Console.Write("->");

                switch (Console.ReadLine())
                {
                    case "0":
                        lastItem = 0;
                        break;
                    case "1":
                        lastItem = 1;
                        break;
                    case "2":
                        lastItem = 2;
                        break;
                    case "3":
                        lastItem = 3;
                        break;
                    case "4":
                        lastItem = 4;
                        break;
                    case "exit":
                        exit = true;
                        break;
                    case "buy":
                        lastItem = byte.MaxValue;
                        Console.Clear();
                        Console.WriteLine("You selected: ");
                        for (var i = 0; i < quantity.Length; i++)
                            if (quantity[i] != 0)
                                Console.WriteLine($"{prices[i] * quantity[i]} for {goods[i]}({quantity[i]})");

                        Console.WriteLine("Press any key to buy and exit");
                        Console.ReadKey();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Unknown command. Press any key to get back to the menu");
                        lastItem = byte.MaxValue;
                        ;
                        Console.ReadKey();
                        break;
                }

                if (lastItem != byte.MaxValue)
                {
                    quantity[lastItem]++;
                    fullPrice += prices[lastItem];
                }

                Console.Clear();
            } while (!exit);
        }

        #endregion
    }
}