using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HangMan();
            


            Console.ReadKey();
        }


        static void HangMan()
        {

            //ask for the user name
            Console.WriteLine(" HI! Welcome to Hangman!!! Lets start out with your name:");
            Console.WriteLine();
            string name= Console.ReadLine();
            // greet user and give the guide lines for the game  
            Console.WriteLine();
            Console.WriteLine(" Well first and foremost" + name + " I want to thank you for playing!! Now the point of the game is for you to guess the word before you run out of guesses! I have faith in you so good luck!!");

            //declaring function variables 
            List<string> list = new List<string> { "nathaniel", "yoMomma", " punk" };
            bool looping = true;
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(0, 2);
            string theWord = list[randomNumber];
            string hidden = "";
            int mistakes = theWord.Length;
            


            // display the word to the user with underscores
            for (int i = 0; i < theWord.Length; i++)
            {
                hidden += "_  ";
               
                {

                }

            }
            Console.WriteLine();
            Console.WriteLine(hidden);
            string allUserGuess = "";

            //start the while loop: this is the actual  hangman game  
            while (looping)
            {
                //declare game variables
                //display the masked word to the user
                Console.WriteLine(" Letters guessed: " + allUserGuess);
                Console.WriteLine(" Mistakes left: " + mistakes);
                Console.WriteLine(wordMask(theWord, allUserGuess));

                //ask the user to put in a guess
                string userGuess = Console.ReadLine().ToUpper();
                

                // checking user guess for format

                if (userGuess.Length == 0)
                {
                    Console.WriteLine(" Make a guess!");

                } // if the user only guesses one char
                else if (userGuess.Length == 1)
                {
                    if (theWord.Contains(userGuess))
                    {


                    }
                    else
                    {
                        mistakes = mistakes - 1;
                    }
                    if (mistakes == 0)
                    {
                        looping = false;

                        Console.WriteLine(" Dang Bro... I had faith :/.. better luck next time");
                    }


                    allUserGuess += userGuess;

                }
                // if the user guesses more than one char
                else if (userGuess.Length > 1)
                {


                }
                if (AllLettersGuessed(wordMask(theWord,allUserGuess))|| userGuess.ToUpper() == theWord.ToUpper())
                {
                    looping = false;
                    Console.WriteLine("Congrats! You won!");

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
            
	

	

      
       
       

	         
	
        // make random word list
        
        // create the list for the words guessed
        


        
     
 
      
    }
        
    }
    }
    
			


			 
		

        
			
               
	
		 
	
       
    
        
      

        

       

        

    

