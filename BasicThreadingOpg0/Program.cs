using System;
using System.Threading;

namespace BasicThreading
{
    class Program
    {

        // Method called from the first thread
        public void WorkThreadFunction()
        {
            // For-loop running 5 times, writing out the current threads name, after each run, it is set to sleep for 10 ms, so it is making it possible for a new thread to run.
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Simple Thread [{0}]", Thread.CurrentThread.Name);
                Thread.Sleep(100);

            }
        }

        // Equal to the other method, just for the second thread
        public void WorkThreadFunction2()
        {

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Simple Thread [{0}]", Thread.CurrentThread.Name);

                Thread.Sleep(100);
            }
        }

    }

    class TheProg
    {
        static void Main(string[] args)
        {
            Program pg = new Program();

            // Instantiating two threads
            Thread thread1 = new Thread(pg.WorkThreadFunction);
            Thread thread2 = new Thread(pg.WorkThreadFunction2);

            // Naming the Threads
            thread1.Name = "thread1";
            thread2.Name = "thread2";

            // Calling the threads to start
            thread1.Start();
            thread2.Start();
            Console.Read();

        }
    }
}
