using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random test_random = new Random();
            int min = 0;
            int max = 100;
            int my_random = test_random.Next(min, max);
            if (my_random > 60)
            {
                Console.WriteLine("More");
            }
            else if (my_random <= 60 && my_random > 30)
            {
                Console.WriteLine(my_random);
            }
            else
            {
                Console.WriteLine("Less");
            }

            Console.WriteLine("Hello Word");
            Console.ReadKey();
        }
    }
}
