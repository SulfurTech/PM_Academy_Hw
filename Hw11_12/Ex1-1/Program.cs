using System;

namespace Ex1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = 2001; var c = 9; var d = 26;

            Console.WriteLine("Expression calculation 1-1 by I.Sierov");
            Console.WriteLine("y = (e^a + 4 lg(c)) / b^(1/2) * |arctg(b)| + 5/sin(a)");

            Console.Write("Input a ");

            var input = Console.ReadLine();
            var a = double.Parse(input);

            double y;
            y = (Math.Exp(a) + 4 * Math.Log10(c)) / Math.Sqrt(b) * Math.Abs(Math.Atan(d)) + 5 / Math.Sin(a);

            Console.WriteLine($"For a = {a}; b = {b}; c = {c}; d = {d} => y = {y}");
        }
    }
}
