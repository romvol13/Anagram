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
        public string Reverse(string input)
        {
            string reversedString = string.Empty;
            StringBuilder result = new StringBuilder();
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                string[] words = input.Split();
                foreach (string word in words)
                {
                    result.Append(ReverseWord(word));
                    result.Append(' ');
                }
                if (result[result.Length-1] == ' ')
                {
                    reversedString = result.ToString().Substring(0, result.Length - 1);
                } else
                {
                    reversedString = result.ToString();
                }
            }
            return reversedString;
        }

        private string ReverseWord(string word)
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
