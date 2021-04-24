using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //get a random number as the answer
            Random rand = new Random();                                                             
            int answer = rand.Next(0, 26);

            //list for max guesses and guess limit
            List<int> guesses = new List<int>();
            int maxGuesses = 7;

            bool correct = false;

            Console.WriteLine("Guess the number between 0 and 25");

            for (int i = 0; i < maxGuesses; i++)                                                //repeat guess attempts up to the maxGuesses
            {
                Console.Write("Enter Guess: ");
                int input = int.Parse(Console.ReadLine());                                      //get the users guess

                guesses.Add(input);                                                             //track all guesses by adding to the list

                if (input < answer)                                                             //if the guess was lower than the answer, tell them that the answer is greater
                {
                    Console.WriteLine("Nope, it's greater than that");
                }
                else if (input > answer)                                                        //if the guess was higher than the answer, tell them that the answer is lower
                {
                    Console.WriteLine("Nope, it's less than that");
                }
                else                                                                            //else the guess was correct
                {
                    correct = true;                                                             //set correct to true to display the appropriate message once out of the loop
                    break;                                                                      //break out of the loop so it doesnt keep asking for guesses after they get it correct
                }

                Console.WriteLine("You have {0} guesses left!", maxGuesses - (i + 1));          //write how many guesses they have left
            }

            if (correct)                                                                        //once out of the loop, if they were correct, tell them how many guesses it took them
            {
                Console.WriteLine("You win!");
                Console.WriteLine("The number was indeed {0}", answer);
                Console.WriteLine("You guessed in {0} guesses", guesses.Count);
            }
            else                                                                                //if they couldnt guess the number in time, let them know what the answer was
            {
                Console.WriteLine("You lose, disappointing");
                Console.WriteLine("The number was {0}, fool", answer);
            }

            WriteGuessLog(guesses);                                                             //display all of their guesses

        }

        public static void WriteGuessLog(List<int> guesses)
        {
            Console.Write("Your guess log: ");
            Console.Write("[");

            for (int i = 0; i < guesses.Count; i++)                                             //loop through the guesses list and write to the console each number
            {
                Console.Write(guesses[i]);

                if (i != guesses.Count - 1)                                                     //only put a comma and space if the item is not the last in the list
                {
                    Console.Write(",");
                    Console.Write(" ");
                }

            }
            Console.Write("]");
        }
    }
}
