using System;

namespace Ex1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Start, End;
            Console.WriteLine("Prime numbers 1-4 by I.Sierov");
            Console.WriteLine("Input interval. In forma 'a b'");
            var input = Console.ReadLine().Split(' ');
            Start = int.Parse(input[0]);
            End = int.Parse(input[1]);

            for (int i = Start; i <= End; i++)
            {
                if (i == 1) continue;
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine($"Prime number is {i}");
                }
            }

        }

        static bool IsPrimeNumber(int A)
        {
            for (int i = 2; i <= Math.Sqrt(A); i++)
            {
                if (A % i == 0)
                    return false;
            }
            return true;
        }
    }
}
