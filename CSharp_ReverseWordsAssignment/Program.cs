using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ReverseWordsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("Welcome to the Reverse Words application!  Please enter a word to reverse.");
                string wordToReverse = Console.ReadLine();

                StringBuilder sb = new StringBuilder();

                ////Loop through the word backwards and append each letter to a string builder - notice we're starting at the END of the word in our loop!
                ////Notice that I have to use the length of the word MINUS ONE as the starting point.  That's because this is zero-indexed, so
                ////  in a 3 letter word, we need to start at position [2] - because the positions are [0], [1], and [2].  That also means we have to keep looping
                ////  while i is greater than OR EQUAL TO zero, since the first character is at [0], not [1].
                for (int i = wordToReverse.Length - 1; i >= 0; i--)
                {
                    sb.Append(wordToReverse[i]);
                }

                string reversedWord = sb.ToString();
                Console.WriteLine($"The word {wordToReverse} backwards is {reversedWord}.");

                //See if the word is a palindroome (same backwards and forwards)
                if (wordToReverse.ToLower() == reversedWord.ToLower())
                {
                    Console.WriteLine($"{wordToReverse} is a palindrome!");
                }
                else
                {
                    Console.WriteLine($"{wordToReverse} is NOT a palindrome!");
                }

                Console.WriteLine("Do another?  [Yes / No]");
                string doAnother = Console.ReadLine();
                if(doAnother.ToLower() == "no" || doAnother.ToLower() == "n")
                {
                    keepGoing = false;
                }
            }

            Console.WriteLine("All done!  Press any key to end.");
            Console.ReadKey();
        }
    }
}
