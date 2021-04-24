using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise variables
            Random rand = new Random();                                                             
            List<int> guesses = new List<int>();
            int answer = rand.Next(0, 26);
            int maxGuesses = 7;
            bool correct = false;


            Console.WriteLine("Guess the number between 0 and 25");

            for (int i = 0; i < maxGuesses; i++)
            {
                Console.Write("Enter Guess: ");
                int input = int.Parse(Console.ReadLine());

                guesses.Add(input);

                if (input < answer)
                {
                    Console.WriteLine("Nope, it's greater than that");
                }
                else if (input > answer)
                {
                    Console.WriteLine("Nope, it's less than that");
                }
                else
                {
                    correct = true;
                    break;
                }
                Console.WriteLine("You have {0} guesses left!", maxGuesses - (i + 1));
            }

            if (correct)
            {
                Console.WriteLine("You win!");
                Console.WriteLine("The number was indeed {0}", answer);
                Console.WriteLine("You guessed in {0} guesses", guesses.Count);
            }
            else
            {
                Console.WriteLine("You lose, disappointing");
                Console.WriteLine("The number was {0}, fool", answer);
            }

            Console.Write("Your guess log: ");
            Console.Write("[");
            for (int i = 0; i < guesses.Count; i++)
            {
                Console.Write(guesses[i]);
                if (i != guesses.Count - 1)
                {
                    Console.Write(",");
                    Console.Write(" ");
                }

            }
            Console.Write("]");

        }
    }
}
