using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class12
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            char[] reversedStringArray = new char[inputString.Length];
           
            for( int i = inputString.Length-1; i>=0; i--)
            {
                reversedStringArray[i] = inputString[i];
            }
            string reversedString = new string(reversedStringArray);
            if(reversedString ==inputString)
            {
                Console.WriteLine("Palindrome");

            }
            else
            {
                Console.WriteLine("not Palindrome. please eneter a palindrome string");
            }
            Console.ReadLine();
        }
    }
}
