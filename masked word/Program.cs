using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masked_word
{
    class Program
    {
        static void Main(string[] args)
        {
            WordMask("blue", "bl");
            Console.ReadKey();

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
        }
    }
}