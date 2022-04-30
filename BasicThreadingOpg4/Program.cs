using System;
using System.Threading;

namespace BasicThreadingOpg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();

            Thread inputThread = new Thread(p.Reader);
            inputThread.Start();

            char ch = '*';
            bool isTrue = true;

            while (isTrue)
            {
                 Console.Write(ch);
                if (inputThread is not null)
                {
                    ch = char.Parse(inputThread.Name);
                }
               
                Thread.Sleep(100);
            }



            

          


        }
    }

    public class Printer
    {

        public void Reader()
        {
            _ = char.Parse(Console.ReadLine());




        }

    }
}
