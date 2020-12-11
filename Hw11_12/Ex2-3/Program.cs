using System;

namespace Ex2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 0)
            {
                double[] Array;
                var arg = args[0].Split();
                int SizeArray = arg.Length;
                Array = new double[SizeArray];
                for (int i = 0; i < SizeArray; i++)
                {
                    if (Double.TryParse(arg[i].Replace(".", ","), out Array[i])) continue;
                    else { Console.WriteLine("-1"); Environment.Exit(0);}
                }

                Array = Sort(Array);

                double Sum = 0, Min, Max, RMS = 0, Average;
                Min = Array[0];
                Max = Array[SizeArray - 1];
                for (int i = 0; i < SizeArray; i++)
                {
                    Sum += Array[i];
                }
                Average = Sum / SizeArray;

                for (int i = 0; i < SizeArray; i++)
                {
                    RMS += Math.Pow(Array[i] - Average, 2);
                }
                RMS /= SizeArray;
                RMS = Math.Sqrt(RMS);

                Console.WriteLine($"Min: {Min};\nMax: {Max};\nAverage: {Math.Round(Average, 4)};\nRMS: {Math.Round(RMS, 4)};\nSum: {Sum}");
                for (int i = 0; i < SizeArray; i++) Console.Write(Array[i] + "; ");
            }
            else
            {
                Console.WriteLine("Statistic 2-3 by I.Sierov");
                Console.Write("Input size of array ");

                int SizeArray = Check();
                Console.WriteLine("Input numbers");
                var Array = InputArray(SizeArray);

                Array = Sort(Array);

                double Sum = 0, Min, Max, RMS = 0, Average;
                Min = Array[0];
                Max = Array[SizeArray - 1];
                for (int i = 0; i < SizeArray; i++)
                {
                    Sum += Array[i];
                }
                Average = Sum / SizeArray;

                for (int i = 0; i < SizeArray; i++)
                {
                    RMS += Math.Pow(Array[i] - Average, 2);
                }
                RMS /= SizeArray;
                RMS = Math.Sqrt(RMS);
                
                Console.WriteLine($"Min: {Min};\nMax: {Max};\nAverage: {Math.Round(Average, 4)};\nRMS: {Math.Round(RMS, 4)};\nSum: {Sum};");
                for (int i = 0; i < SizeArray; i++) Console.Write(Array[i] + "; ");
            }
        }
        
        static double[] Sort(double[] Array)
        {
            double temp;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return Array;
        }

        static double[] InputArray(int SizeArray)
        {
            string Input;
            int i = 0;
            double[] Array;
            Array = new double[SizeArray];
            while (i < SizeArray)
            {
                Input = Console.ReadLine();
                if (Double.TryParse(Input.Replace(".",","), out Array[i])) i++;
                else { Console.WriteLine("Invalid number"); }
            }
            return Array;
        }

        static int Check()
        {
            string input;
            input = Console.ReadLine();
            if (int.TryParse(input, out int n))
            {
                if (n > 0) return n;
                else { Console.WriteLine("Invalid size"); }
            }
            else
            {
                { Console.WriteLine("Invalid size"); }
            }
            return Check();
        }
    }
}
