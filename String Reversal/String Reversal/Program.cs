using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string to be reversed");
            string input = Console.ReadLine();
            char[] allCharacters = input.ToCharArray();
            string IterativeOutput = "";
            string recursiveOutput = new string(input.ToCharArray().Reverse().ToArray());

            for (int i = 0;  i < allCharacters.Length; i++)
            {
                IterativeOutput += allCharacters[allCharacters.Length - i -1];
            }
            Console.WriteLine("Iterative Reversed " + IterativeOutput);
            Console.WriteLine("Recursively Reversed " + recursiveOutput); 
            Console.ReadLine();

        }
    }
}
