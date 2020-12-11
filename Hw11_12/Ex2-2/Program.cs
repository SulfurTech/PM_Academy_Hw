using System;

namespace Ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Square 2-2 by I.Sierov");
                Console.WriteLine("Input type of figure and sizes. Choose 'exit' to close.");
                Console.WriteLine("You can input: \ncircle radius\nsquare side\nrectangle side1 side2\ntriangle side");
                SquareCalculating();
            }
            else
            {
                var arg = args[0].Split();
                if (!CheckFigure(arg)) Console.WriteLine(-1);
                else if (!CheckDouble(arg)) Console.WriteLine(-1);
                else Console.WriteLine(Math.Round(Square(arg), 4));

            }
        }

        static void SquareCalculating()
        {
            const string EndWord = "exit";
            string[] input;

            do
            {
                Console.Write("Input your figure and sides ");
                input = Console.ReadLine().Split();

                if (input[0] == "") { Console.WriteLine("Any input."); continue; }
                if (input[0] == EndWord)
                {
                    Console.WriteLine("Thanks for using!");
                    break;
                }

                if (!CheckFigure(input)) { Console.WriteLine("Invalid figure. You can input: \ncircle radius\nsquare side\nrectangle side1 side2\ntriangle side"); continue; }
                if (!CheckDouble(input)) { Console.WriteLine("Invalid sides. You can input: \ncircle radius\nsquare side\nrectangle side1 side2\ntriangle side"); continue; }
                Console.WriteLine(Math.Round(Square(input), 4));

            } while (true);
        }

        static bool CheckFigure(string[] input)
        {
            if (input[0] == "circle" || input[0] == "square" || input[0] == "triangle" || input[0] == "rectangle") { return true; }
            else return false;
        }

        static bool CheckDouble(string[] input)
        {
            if (input[0] == "rectangle" && input.Length == 3)
            {
                if (!Double.TryParse(input[1].Replace(".", ","), out double side1) || !Double.TryParse(input[2].Replace(".", ","), out double side2) || side1 <= 0 || side2 <= 0) return false;
                else return true;
            }
            else if ((input[0] == "square" || input[0] == "circle" || input[0] == "triangle") && input.Length == 2)
            {
                if (!Double.TryParse(input[1].Replace(".", ","), out double side) || side <= 0) { return false; }
                else return true;
            }
            else return false;
        }

        static double Square(string[] input)
        {
            if (input[0] == "circle")
            {
                Double.TryParse(input[1].Replace(".", ","), out double radius);
                return (Math.PI * Math.Pow(radius, 2));
            }
            if (input[0] == "square")
            {
                Double.TryParse(input[1].Replace(".", ","), out double side);
                return (Math.Pow(side, 2));
            }
            if (input[0] == "triangle")
            {
                Double.TryParse(input[1].Replace(".", ","), out double side);
                return (Math.Pow(side, 2) * Math.Sqrt(3) / 4);
            }
            if (input[0] == "rectangle")
            {
                Double.TryParse(input[1].Replace(".", ","), out double side1);
                Double.TryParse(input[2].Replace(".", ","), out double side2);
                return (side1 * side2);
            }
            return -1;
        }
    }
}
