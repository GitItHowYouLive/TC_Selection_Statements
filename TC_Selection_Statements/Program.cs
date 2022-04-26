using System;

namespace TC_Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuickGame();
            SwitchStatements();
        }

        static void QuickGame()
        {
            Console.WriteLine("Welcome to One-Shot! \n It's the hot new guessing game where you've only got one shot! \n Can you guess the random number?!");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("You guessed too low! Oh well...");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("You guessed too high! Calm down!");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("You guessed it! Wow! Take a picture, because no one will believe you!");
            }
            else
            {
                Console.WriteLine("I don't even know how, but you broke it. Great job, I guess.");
            }
        }

        static void SwitchStatements()
        {
            Console.WriteLine("Welcome to the first day of school! \n Please inform us of your favorite subject so that we can place you in the appropriate 'clique'.");
            string fav = Console.ReadLine();

            switch (fav)
            {
                case "math":
                    Console.WriteLine("Math? Welcome to the nerds! L337 4 LIFE!");
                    break;
                case "english":
                    Console.WriteLine("So I guess you like words, huh? Guess you can be a theater kid. They have low standards anyway.");
                    break;
                case "spanish":
                    Console.WriteLine("Oh, you exotic or something? You're one of the emo kids now. Congrats.");
                    break;
                case "science":
                    Console.WriteLine("You know how to blow stuff up, so be whoever you want.");
                    break;
                case "history":
                    Console.WriteLine("Really? Who sits around caring about stuff that already happened? You are friends with the bullies.");
                    break;
                default:
                    Console.WriteLine($"I don't even know what {fav} is, so you get to be a jock.");
                    break;
            }
        }
    }
}
