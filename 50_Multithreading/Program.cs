// Thread:
// An execution path of a program.
// We can use multiple threads to perform, different tasks of our program at the same time.
// Current thread running is "main" thread using System.Threading;

using System;
using System.Threading;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "main thread";
            //Console.WriteLine(mainThread.Name);
            /*
            CountDown();
            CountUp();
            */

            //Thread thread1 = new Thread(CountDown); // without args
            //Thread thread2 = new Thread(CountUp); // without args
            Thread thread1 = new Thread(() => CountDown("Timer #1")); // lambda expression
            Thread thread2 = new Thread(() => CountUp("Timer #2")); // lambda expression
            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }
    public static void CountDown(String name)
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
            Console.WriteLine();
        }
    public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
            Console.WriteLine();
        }
    }
}
