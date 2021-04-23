using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class4
    {
        void swap(int a, int b)
        {

            int w = a;
            a = b;
            b = w;
            Console.WriteLine("a="+a);
            Console.WriteLine("b=" + b);

        }
        static void Main(string[] args)
        {
            
           
            
            
            Class4 class4 = new Class4();
            class4.swap(5,6);
            Console.ReadLine();


        }
    }
}
