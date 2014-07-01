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
WordMask("nathaniel","nathaniel");
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
            List<string> list = new List<string> { " nathaniel", "yoMomma", " punk" };
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

                        for (int i = 0; i < theWord.Length; i++)
                        {
                            if (Convert.ToChar(userGuess) == theWord[i / 2])
                            {
                                hidden = hidden.Remove(i / 2, 1).Insert(i / 2, userGuess);
                                Console.WriteLine(userGuess, "");
                            }
                        }
                    }
                    else
                    {
                        mistakes = mistakes - 1;
                    }

                    
                    {
                        
                        
                    }
                   
                    { 
                       
                        
               
                        
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
                Console.WriteLine(hidden);

                Console.WriteLine(" Letters guessed: " + allUserGuess);
                Console.WriteLine(" Mistakes left: " + mistakes);
            }
        }

            
             static void WordMask(string a, string b)
        {
            string word = a;
            string guessed = b;
            string temp = " ";

            for (int i = 0; i < word.Length; i++)
            {
                char temp1 = word[i];
                if (guessed.Contains(temp1))
                {
                    temp = temp + temp1 + " ";
                }
                else
                {
                    temp = temp + "_ ";
                }

                Console.WriteLine(temp);


       }
            
	

	

      
       
       

	         
	
        // make random word list
        
        // create the list for the words guessed
        


        
     
 
      
    }
        
    }
    }
    
			


			 
		

        
			
               
	
		 
	
       
    
        
      

        

       

        

    

