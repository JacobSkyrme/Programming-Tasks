using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Non_Repeated_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input any string.");
            char[] allChars = Console.ReadLine().ToCharArray();

            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            for(int i = 0; i < allChars.Length;i++)
            {
                char currentChar = allChars[i];
                if(charCounter.ContainsKey(currentChar))
                {
                    charCounter[currentChar]++;
                }
                else
                {
                    charCounter.Add(currentChar, 1);
                }
            }
            bool noRepeatChar = false;
            for (int i = 0; i < allChars.Length; i++)
            {
                char currentChar = allChars[i];

                if (charCounter[currentChar] == 1)
                {
                    Console.WriteLine("The first repeating character is " + currentChar);
                    noRepeatChar = true;
                    break;
                }
            }
            if (noRepeatChar == false)
            {
                Console.WriteLine("There were no repeating characters.");
            }
            Console.ReadLine();
        }
    }
}
