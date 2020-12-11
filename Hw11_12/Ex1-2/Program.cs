using System;

namespace Ex1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сalculation of margin 1-2 by I.Sierov");
            Console.Write("Input Name1 ");
            var name1 = Console.ReadLine();
            Console.Write("Input Name2 ");
            var name2 = Console.ReadLine();

            Double w1, draw, w2;
            Console.WriteLine("Input Win1 coefficient");
            var input = Console.ReadLine();
            Double.TryParse(input.Replace(".", ","), out w1);
            Console.WriteLine("Input Draw coefficient");
            input = Console.ReadLine();
            Double.TryParse(input.Replace(".", ","), out draw);
            Console.WriteLine("Input Win2 coefficient");
            input = Console.ReadLine();
            Double.TryParse(input.Replace(".", ","), out w2);

            double Margin = 1 - 1 / (1 / w1 + 1 / draw + 1 / w2);

            double W1Percent = 1 / w1 * (1 - Margin);
            W1Percent = Math.Round(W1Percent, 4) * 100;
            double DrawPercent = 1 / draw * (1 - Margin);
            DrawPercent = Math.Round(DrawPercent, 4) * 100;
            double W2Percent = 1 / w2 * (1 - Margin);
            W2Percent = Math.Round(W2Percent, 4) * 100;

            Margin = Math.Round(Margin * 10000) / 100;

            Console.WriteLine($"Win {name1}: {W1Percent}%");
            Console.WriteLine($"Win {name2}: {W2Percent}%");
            Console.WriteLine($"Draw: {DrawPercent}%");
            Console.WriteLine($"Margin: {Margin}%");
        }
    }
}
