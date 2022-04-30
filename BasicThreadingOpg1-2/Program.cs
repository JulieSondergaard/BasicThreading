using System;
using System.Threading;

namespace BasicThreadingOpg1
{
    class Program
    {

        // Svar på spørgsmål "Er det smart at bruge Thread.Sleep(1000);"? - Det kan være smart hvis man gerne vil have at de andre tråde skal gå i gang samtidig
        // da det giver plads til at de efterfølgende tråde ligeledes kan gå igang. Hvis ikke man bruger Sleep-funktionen, så vil en tråd køre videre før den næste 
        // påbegyndes. Jeg tænker at særligt i større funktioner med mange steps, kan det være relevant at bruge funktionen. JS

        static void Main(string[] args)
        {
            ThreadingCode t = new ThreadingCode();

            Thread fun = new Thread(t.ThreadingIsFun);
            Thread superFun = new Thread(t.ThreadingIsSuperFun);
            fun.Start();
            superFun.Start();
            Console.Read();
        }

    }
    class ThreadingCode
    {
        public void ThreadingIsFun()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("c#-trådning er nemt!");
                Thread.Sleep(1000);

            }
        }

        public void ThreadingIsSuperFun()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde...");
                Thread.Sleep(1000);
            }
        }
    }
}
