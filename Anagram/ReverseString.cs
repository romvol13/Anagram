using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class ReverseString
    {
        public string reversedString;
        public string Reverse(string input)
        {
            StringBuilder result = new StringBuilder();
            Console.WriteLine($"Original string: {input}");
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Your string is empty or it has only one symbol");
            }
            else
            {
                string[] words = input.Split();
                foreach (string word in words)
                {
                    result.Append(ReverseWord(word));
                    result.Append(' ');
                }
                reversedString = result.ToString().TrimEnd();
            }
            return reversedString;
        }
        public string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            int leftIndex = 0;
            int rightIndex = charArray.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (!char.IsLetter(charArray[leftIndex]))
                {
                    leftIndex++;
                }
                else if (!char.IsLetter(charArray[rightIndex]))
                {
                    rightIndex--;
                }
                else
                {
                    char temporary = charArray[leftIndex];
                    charArray[leftIndex] = charArray[rightIndex];
                    charArray[rightIndex] = temporary;
                    leftIndex++;
                    rightIndex--;
                }
            }
            string reversedWord = new string(charArray);
            return reversedWord;
        }
    }
}
