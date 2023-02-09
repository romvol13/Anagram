using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString anagram = new ReverseString();
            Console.WriteLine("Type the string you want to reverse:");
            Console.WriteLine($"Reversed string:{anagram.Reverse(Console.ReadLine())}");
        }
    }
}