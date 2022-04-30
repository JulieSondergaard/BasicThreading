using System;
using System.Threading;

namespace BasicThreadingOpg3
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomTemperatureManager randomTemp = new RandomTemperatureManager();

            Thread threadTemp = new Thread(randomTemp.RandomTemperature);
            threadTemp.Start();

            bool isAlive = true;
            while (isAlive)
            {
                Thread.Sleep(10000);
                if (!threadTemp.IsAlive) 
                {
                    isAlive = false;
                    Console.WriteLine("Alarm-thread terminated!");
                    
                }
            }


        }

    }
    
    class RandomTemperatureManager
    {
        public void RandomTemperature()
        {
            var random = new Random();

            int alarm = 0;

            bool repeat = true;

            while (repeat)
            {
                int randomTemp = random.Next(-20, 121);
                Thread.Sleep(2000);
                Console.WriteLine(randomTemp);

                if ((randomTemp < 0) || (randomTemp > 100))
                {
                    Console.WriteLine("Alarm");
                    alarm++;
                }

                if (alarm > 2)
                {
                    repeat = false;
                }
            }
        }
    }
}
