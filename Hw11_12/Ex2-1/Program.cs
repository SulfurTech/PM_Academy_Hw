using System;

namespace Ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game rock-paper-scissors 2-1 by I.Sierov");
            Console.WriteLine("Choose 'rock', 'paper' or 'scissors' to play with PC. Choose 'exit' to close.");
            play();
        }

        static void play()
        {
            Random rand = new Random();
            const string EndWord = "exit";
            string input;
            int PCanswer;
            string PCchoise = "";
            string result = "";
            string[] History;
            History = new string[1000];

            int k = 0;

            do
            {
                Console.Write("Input your choice ");
                input = Console.ReadLine();

                if (input == EndWord)
                {

                    Console.WriteLine();
                    if (k != 0) Console.WriteLine("History of your games");

                    for (int i = 0; i < k; i++)
                    {
                        Console.WriteLine(History[i]);
                    }

                    Console.WriteLine("Thanks for playing");
                    break;
                }

                PCanswer = rand.Next(1, 4);
                if (PCanswer == 1) { PCchoise = "paper"; }
                if (PCanswer == 2) { PCchoise = "rock"; }
                if (PCanswer == 3) { PCchoise = "scissors"; }

                if (Check(input))
                {
                    if (PCchoise == input)
                    {
                        result = $"You show {input} and PC show {PCchoise}. Its draw";

                    }
                    else if (PCchoise == "rock" && input == "paper" || PCchoise == "scissors" && input == "rock" || PCchoise == "paper" && input == "scissors")
                    {
                        result = $"You show {input} and PC show {PCchoise}. Your winner";
                    }
                    else if (input == "rock" && PCchoise == "paper" || input == "scissors" && PCchoise == "rock" || input == "paper" && PCchoise == "scissors")
                    {
                        result = $"You show {input} and PC show {PCchoise}. Your loser";
                    }
                    Console.WriteLine(result);
                    History[k] = result;
                    k++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Choose 'rock', 'paper' or 'scissors' to play with PC. Choose 'exit' to close. \nTry again");
                }

            } while (true);
        }

        static bool Check(string input)
        {
            if ((input == "scissors") || (input == "paper") || (input == "rock"))
            {
                return true;
            }
            return false;
        }


    }
}
