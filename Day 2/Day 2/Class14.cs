using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class14
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            int[] charCount = new int[256];
            
            for (int i =0; i <inputString.Length; i++)
            {
                charCount[inputString[i]]++;
            }
            int max = -1;
            char character = ' ';
            for (int i = 0; i < inputString.Length; i++)
            {
                if (max < charCount[inputString[i]])
                {
                    max = charCount[inputString[i]];
                    character = inputString[i];
                }
            }

            Console.WriteLine("the highest occuring character is =" + "\t" + character);
         
            Console.WriteLine("It's count is" + "\t" + max);
           
            Console.ReadLine();
        }
    }
}
