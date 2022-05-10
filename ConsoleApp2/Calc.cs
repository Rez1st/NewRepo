using System;

namespace ConsoleApp2
{
    internal static class Calc
    {
        public static void Start()
        {
            Console.WriteLine("Welcome to simple calculator!");
            var useCalc = true;
            var leftOperand = "Input Left operand";
            var rightOperand = "Input Right operand";

            void Color(string str, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.Write(str);
                Console.ForegroundColor = ConsoleColor.White;
            }

            int GetNumber(string message = null)
            {
                // scope
                var i = int.MaxValue; // int i,j; int j,k = 0; int i = default; int i =0;
                var noExit = true;
                // We put cw outside the loop to output it only once
                Console.WriteLine(message ?? "Input number"); // ?? (null) - what is ??

                do // Loop to get the number
                {
                    var userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out i)) //
                        Console.WriteLine("Input was not in correct format, please try again");
                    else
                        noExit = false;
                } while (noExit);

                return i;
            }

            do
            {
                //Homework - extend calculator and make it for scientist
                //exp - exponent
                //sqrt - square root
                //mod - modulo
                Console.Write("Please input action eg:\n --->[");
                Color("\"+ - / *\"", ConsoleColor.Green);
                Console.Write("]<---\nOR\n");
                Color(" \"A - Addition, S - Subtract, D - Divide, M - Multiply\"\n", ConsoleColor.DarkGreen);
                Console.Write("Input [");
                Color("exit", ConsoleColor.DarkRed);
                Console.Write("] - to finish\n");

                Console.Write("->");

                try
                {
                    switch (Console.ReadLine()?.ToLower())
                    {
                        case "+":
                        case "a":
                        case "addition":
                        case "add":
                            Console.WriteLine(GetNumber(leftOperand) + GetNumber(rightOperand));
                            break;
                        case "-":
                        case "s":
                        case "subtract":
                        case "sub":
                            Console.WriteLine(GetNumber(leftOperand) - GetNumber(rightOperand));
                            break;
                        case "*":
                        case "m":
                        case "multiply":
                        case "mul":
                            Console.WriteLine(GetNumber(leftOperand) * GetNumber(rightOperand));
                            break;
                        case "/":
                        case "d":
                        case "divide":
                        case "div":
                            Console.WriteLine(GetNumber() / GetNumber("Right operand input not 0!")); // No text passed
                            break;
                        case "exit":
                            useCalc = false; // In case of exit - close the calc
                            break;
                        default:
                            Console.WriteLine("No such action defined");
                            break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero(0), surprise!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something unexpected happen");
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
                Console.Clear();
            } while (useCalc);


            Console.ReadLine();
        }
    }
}