using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class10
    {
        static void Main()

        {
            object str = "hello";
            char[] value = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(value);
            Console.WriteLine("Using Equality operator" + (str == str2));
            Console.WriteLine("Using Equals() method {0}", str.Equals(str2));
            Console.ReadLine();
        }
    }
}
