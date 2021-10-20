using System;
using System.Threading;
namespace Task1
{
    class MyFallingString
    {
      
           

        static private string GenIndent()
        {
            return new string(' ', MyRand.Next(0, Console.WindowWidth-1));
        }
        static private string GenString()
        {
            int length = MyRand.Next(5, 10);
            char[] str = new char[length];
            //string str = new string(' ', length);
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int index;
            for (int i = 0; i < str.Length; i++)
            {
                index = MyRand.Next(0, abc.Length);
                str[i]=abc[index];
            }
            return new string(str);
        }

        static public void ToFall()
        {
            while (true)
            {
                string indent = GenIndent();
                string sourceStr = null;
                sourceStr = GenString();
                sourceStr += new string(' ', Console.WindowHeight);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string sumStr = "";
                for (int i = 0; i < sourceStr.Length; i++)
                {
                    /*if (i >= Console.WindowHeight)
                    {
                        sourceStr = sourceStr.Substring(0, sourceStr.Length - Console.WindowHeight-1);
                        sourceStr+=;
                    }*/
                    Console.SetCursorPosition(indent.Length, 0);
                    sumStr = sourceStr[i] + $"\n{indent + sumStr}";
                    Console.Write(sumStr);
                    Thread.Sleep(50);
                }
                //Console.SetCursorPosition(0, 0);
                //Console.ResetColor();
                Thread.Sleep(200);
            }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Thread[] threadArray = new Thread[20];
            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i] = new Thread(MyFallingString.ToFall);
                threadArray[i].Start();
                Thread.Sleep(500);
            }
            MyFallingString.ToFall();
            Console.SetWindowSize(160, 30);
            //MyFallingString.ToFall();
        }
    }
}
