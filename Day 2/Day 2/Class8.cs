using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Author
    {
        public string Name1;
        public int rank1;
    }
    class Class8
    {
        public string Name2;
        public int rank2;
        static void Main(string[] args)
        {

            Class8 class8 = new Class8();
            Author author = new Author();
            bool result;
            bool result1;
            result = author is Author;
            result1 = class8 is Author;
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadLine();
        }

        }
    }
