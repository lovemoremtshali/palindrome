using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (char.ToLower(word[i]) != char.ToLower(word[word.Length - i - 1]))
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("The word {0} is a palindrome.", word);
            }
            else
            {
                Console.WriteLine("The word {0} is not a palindrome.", word);
            }
            Console.ReadLine();
        }
    }
}
