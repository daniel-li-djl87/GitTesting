using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(18, "Daniel");
            Console.WriteLine("Hello {0}", p.Name);

            //Edited Hello feature
            for ( int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nice to meet you!");
            }

            //New Goodbye feature
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
