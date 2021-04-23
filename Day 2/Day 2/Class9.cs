using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    public struct Person
    {


        public String Name { get; set; }
        public Person(string _name)
        {
            Name = _name;
        }
    }
    public struct Dog
    {


        public string Breed { get; set; }
        public Dog(string _breed)
        {
            Breed = _breed;
        }
    }
    class Class9
    {
        public static void showvalue(Object o)
        {
            if (o is Person p)
            {
                Console.WriteLine(p.Name);
            }
            else if (o is Dog d)
            {
                Console.WriteLine(d.Breed);
            }

        }

        static void Main()

        {
            object o = new Person("shamitha");
            showvalue(o);

            o = new Dog("Husky");
            showvalue(o);
            Console.ReadLine();
        }
    }
}
