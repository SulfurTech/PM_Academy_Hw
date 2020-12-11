using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                try
                {
                    int FirstNumberPosition = 0, SecondNumberPosition = -1;
                    int UTF;
                    char ch;
                    var Input = Console.ReadLine().Replace(" ", "").Split("");
                    int FirstOperation, SecondOperation = -1, ThirdOperation = -1;
                    if (Input[0] != "-") { FirstOperation = -1; }
                    else FirstOperation = 0;
                    FirstNumberPosition = FirstOperation + 1;
                    for (int i = FirstNumberPosition; i < Input.Length; i++)
                    {
                        if (!Char.TryParse(Input[i], out ch)) throw new ArgumentOutOfRangeException();
                        UTF = ch;
                        if (UTF >= 48 && UTF <= 57) continue;
                        else if (UTF >= 42 && UTF <= 47 || UTF == 92 || UTF == 94 || UTF == 124 || UTF == 37 || UTF == 38) SecondOperation = i;
                        else throw new ArgumentOutOfRangeException();

                        if (SecondOperation - FirstOperation == 1 || SecondOperation == Input.Length - 1) throw new ArgumentOutOfRangeException();
                    }
                    if (!Char.TryParse(Input[SecondOperation + 1], out ch)) throw new ArgumentOutOfRangeException();
                    UTF = ch;
                    if (UTF >= 48 && UTF <= 57) SecondNumberPosition = SecondOperation + 1;
                    else if (UTF >= 42 && UTF <= 47 || UTF == 92 || UTF == 94 || UTF == 124 || UTF == 37 || UTF == 38) ThirdOperation = SecondOperation + 1;
                    else throw new ArgumentOutOfRangeException();
                    if (ThirdOperation != -1)
                    {
                        if (ThirdOperation == Input.Length - 1) throw new ArgumentOutOfRangeException();
                        if (!Char.TryParse(Input[ThirdOperation + 1], out ch)) throw new ArgumentOutOfRangeException();
                        UTF = ch;
                        if (UTF >= 48 && UTF <= 57) SecondNumberPosition = ThirdOperation + 1;
                        else throw new ArgumentOutOfRangeException();
                    }


                }
                catch (Exception e) { Console.WriteLine("Error"); Environment.Exit(0); }
            }
            else { }
            }
    }
}
