using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_01
{
    class Program
    {
        static public int Method1(int FirstArg1, int SecondArg1)
        {
            return FirstArg1 + SecondArg1;
        }
        static public int Method2(ref int FirstArg2, ref int SecondArg2)
        {
            if (FirstArg2 > SecondArg2)
            {
                return FirstArg2 * SecondArg2;
            }
            else
            {
                return (FirstArg2 * 10) / SecondArg2;
            }

        }
        static void Main(string[] args)
        {
            Random test_random = new Random();
            int firstM = test_random.Next(0, 100);
            int seconM = test_random.Next(0, 100);
            Console.WriteLine(Method1(Method2(ref firstM, ref seconM), test_random.Next(0, 100)));
            Console.ReadKey();

        }
    }
}
