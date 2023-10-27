using System;

namespace c__video.Projects
{
    class guess_Game
    {
        static void Main(string[] args)
        {
            do
            {
                int playerGuess;
                int randomRumber;
                int score = 0;
                int round = 0;
                bool isValidInput = false;
                int roundDisplay = 0;

                Random random = new Random();

                do
                {
                    Console.WriteLine("How many rounds do you want to play?");
                    string input = Console.ReadLine();
                    isValidInput = int.TryParse(input, out round);

                    if (!isValidInput || round <= 0)
                    {
                        Console.WriteLine("Please type a valid number greater than 0.");
                    }
                } while (!isValidInput || round <= 0);

                for (int i = 0; i < round; i++)
                {
                    roundDisplay++;
                    Console.WriteLine($"------\nRound {roundDisplay}\nGuess a number between 1 and 5...");

                    playerGuess = Convert.ToInt32(Console.ReadLine());
                    randomRumber = random.Next(1, 6);

                    if (playerGuess > 5)
                    {
                        Console.WriteLine("Please select a number between 1 and 5");
                        break;
                    }
                    else if (playerGuess < 1)
                    {
                        Console.WriteLine("Please select a number between 1 and 5");
                        break;
                    }
                    else if (playerGuess == randomRumber)
                    {
                        Console.WriteLine("......\nCorrect!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("......\nWrong!");
                        Console.WriteLine($"The correct guess was: {randomRumber}");
                    }
                }
                Console.WriteLine($"Your Results:\n {score}/{round}");
                Console.WriteLine("---------");
                Console.WriteLine("Would you like to play again? (Y = Yes, N = No)");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}
