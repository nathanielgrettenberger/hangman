using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masked_word2
{
    class Program
    {
        static void Main(string[] args)
        {

            HangMan();
            Console.ReadLine();

        }
        static void HangMan()
        {
            // boolean to hold wether or not they lost
            bool playing = true;
            string playername;
            int lives = 7; // number of guesses
            List<string> wordBank = new List<string> { "nickleback", "yomomma", "nathaniel", "book", "generator", "punk", "wimpmade" };

            string wordToGuess = wordBank[new Random().Next(0, wordBank.Count())].ToUpper();
            string lettersNamed = string.Empty;

           Console.WriteLine("Enter your name");
           Console.ReadLine();     
            // start our game loop

            while (playing)
            {
                // show them the masked word
                Console.WriteLine(wordMask(wordToGuess, lettersNamed));
                // tell them how many lives left
                Console.WriteLine("you have" + lives + "lives left");
                // ask for input
               
                string input = Console.ReadLine().ToUpper();

                // determine if it a letter of a word
                if (input.Length == 1)
                {
                    // guessed a letter, add it to string
                    lettersNamed += input;
                    // letter guess to determine if it a guess
                    //correct
                    if (wordToGuess.Contains(input))
                    {
                        // correct guess
                        Console.WriteLine("Good Job Homie!!");
                        if (AllLettersGuessed(wordMask(wordToGuess, lettersNamed)))
                        {
                            playing = false;
                            Console.WriteLine("Damn homie! You the Man homie");
                        }
                        if (wordToGuess.Contains(wordToGuess))
                        {
                            Console.WriteLine(" You Guessed That Already");
                            
                        }

                    }
                    else
                    {
                        Console.WriteLine("Crappy Guess!");
                        lives--;
                    }
                    if (lives == 0)
                    {
                        playing = false;
                        Console.WriteLine(" Damn You really need to practice");
                        
                    }

                    //wordguess
                    if (wordToGuess == input)
                    {
                        Console.WriteLine("Dang homie, You won!!");
                    }
                  
                   
                }


            }
        }




        static string wordMask(string wordToGet, string lettersNamed)
        {
            // strign to return our masked string
            string returnString = " ";

            // looping over the string to examine each char
            for (int i = 0; i < wordToGet.Length; i++)
            {
                // get a letter out of the index of the word to get
                char letter = wordToGet[i];
                // if the letter in the word to guess has been guessed by the user
                if (lettersNamed.ToUpper().Contains(letter.ToString().ToUpper()))
                {
                    // print the right answer

                    returnString += letter + " ";
                }
                else
                {
                    // add underscore to return string
                    returnString += "_ ";
                }
            }
            //return the string
            return returnString;
        }
        static bool AllLettersGuessed(string wordMask)
        {

            //determine if the usre has guessed all the letter of the word

            if (wordMask.Contains("_"))
            {
                return false;

            }
            else
            {
                return true;
            }
            // on other way to do it: 
            // return !wordMask.Contians("_");

        }
    }
}
