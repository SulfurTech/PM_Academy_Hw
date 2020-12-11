using System;
using System.Diagnostics;

namespace Ex2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is number 2-4 by I.Sierov");
            Console.WriteLine("Input interval and try choose computer number");
            Console.WriteLine("Input interval: FirstNumber SecondNumber");
            int[] Interval = Check();

            var random = new Random();
            var PcNumber = random.Next(Interval[0], Interval[1] + 1);

            Stopwatch Timer = new Stopwatch();
            Timer.Start();

            int attempts = Playing(PcNumber);
            
            Timer.Stop();

            double n = Math.Round(Math.Log(PcNumber) / Math.Log(2)) ;
            if (PcNumber - Math.Pow(2, n) > Math.Pow(2, n + 1) - PcNumber) n++;

            var Points = 100 * (n - attempts) / n;

            Console.WriteLine($"Your points: {Math.Round(Points,2)}; \nYour attempts: {attempts}; \nTime of playing: {Timer.Elapsed}");
        }

        static int[] Check()
        {
            string[] input;
            input = Console.ReadLine().Split();
            if (input.Length != 2) { Console.WriteLine("Invalid interval"); return Check(); }
            if (int.TryParse(input[0], out int start) && int.TryParse(input[1], out int end))
            {
                if ((start > 0) && (end > start))
                {
                    int[] Arr = { start, end };
                    return Arr;
                }
                else { Console.WriteLine("Invalid interval"); }
            }
            else
            {
                { Console.WriteLine("Invalid interval"); }
            }
            return Check();
        }

        static int Playing(int InputNumber)
        {
            int attempts = 0, UserNumber = 0 ;
            string input;
            do
            {
                Console.WriteLine("Input your attempt");
                input = Console.ReadLine();
                if (int.TryParse(input, out UserNumber))
                {
                    attempts++;
                    if (UserNumber > InputNumber) Console.WriteLine("Too high");
                    else if (UserNumber < InputNumber) Console.WriteLine("Too low");
                }
                else
                {
                    { Console.WriteLine("Invalid number"); }
                }

            } while (InputNumber != UserNumber);

            return attempts;
        }
    }
}
