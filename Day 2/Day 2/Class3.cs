using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class3
    {
        void CheckOddEven(int a)
        {
            
            if (a % 2 == 0)
            {
                Console.WriteLine("even number");

            }
            else
            {
                Console.WriteLine("Odd number");

            }
            
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Class3 class3 = new Class3();
            class3.CheckOddEven(x);
            Console.ReadLine();


        }
    }
}
