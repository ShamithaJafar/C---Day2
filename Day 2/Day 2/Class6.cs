using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class6
    {
        void Swap(ref int a, ref int b)
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




            Class6 class6 = new Class6();
            int a = 5, b = 6;

            class6.Swap(ref a, ref b);
            Console.WriteLine("inside main funtion");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadLine();


        }
    }
}
