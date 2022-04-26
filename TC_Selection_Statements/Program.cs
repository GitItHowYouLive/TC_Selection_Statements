using System;

namespace TC_Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuickGame();
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
    }
}
