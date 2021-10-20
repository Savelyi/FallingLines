using System;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            string indent = new string(' ', 50);
            string sourceStr = "Hello";
            string sourceStr1 = sourceStr + new string(' ', Console.WindowHeight);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string sumStr = "";
                for (int i = 0; i < sourceStr1.Length; i++)
                {
                    Console.SetCursorPosition(indent.Length, 0);
                    sumStr = sourceStr1[i] + $"\n{indent + sumStr}";
                    Console.Write(sumStr);
                    Thread.Sleep(100);
                }
                Console.SetCursorPosition(0, 0);
                Console.ResetColor();
                Thread.Sleep(2000);
            }
        }
    }
}

