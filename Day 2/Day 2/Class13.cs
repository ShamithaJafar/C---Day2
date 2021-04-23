using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class13
    {
        
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            int c = 0;
            for (int i = 0 ; i < inputString.Length; i++)
            {

                if (inputString[i] == 'a' || inputString[i] == 'e' || inputString[i] == 'i' || inputString[i] == 'o' || inputString[i] == 'u')
                {
                   c = c+1;

                }


            }

            Console.WriteLine("vowels =");
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
