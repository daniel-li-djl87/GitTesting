using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //New Hello feature
            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nice to meet you!");
            }

            //New Goodbye feature
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
