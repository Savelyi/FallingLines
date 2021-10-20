using System;
using System.Threading;

namespace Task
{
    class Program
    {

        static int counter=0;
        static void Method()
        {

            Console.WriteLine("Hello " + Thread.CurrentThread.Name);
            Thread thread = new Thread(Method);
            thread.Name = "Thread " + (++counter);
            Thread.Sleep(1000);
            thread.Start();

        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(Method);
            thread.Name = "Thread " + counter; 
            thread.Start();
            
        }
    }
}
