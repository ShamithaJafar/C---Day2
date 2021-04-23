using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class5
    {
        void swap(int a, int b)
        {

            int w = a;
            a = b;
            b = w;
            Console.WriteLine("inside swap funtion");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }
        static void Main(string[] args)
        {




            Class5 class5 = new Class5();
            int a = 5, b = 6;

            class5.swap(a, b);
            Console.WriteLine("inside main funtion");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadLine();


        }
    }
}
