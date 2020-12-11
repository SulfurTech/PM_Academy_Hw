using System;

namespace Ex1_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculation of the sum 1-3 by I.Sierov");
            int year = 2001;
            double eps = 1 / Convert.ToDouble(year);
            double sum = 0;
            double i = 1;
            Console.Write($"Sum of row 1/((i+1)*i) for {eps}");

            while ((1 / i - 1 / (i + 1)) > eps)
            {
                sum += 1 / i / (i + 1);
                i++;
            }

            sum += 1 / i / (i + 1);

            Console.Write($" = {sum}");

        }
    }
}
