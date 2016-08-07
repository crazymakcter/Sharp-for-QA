using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_02
{
     class First
    {
        public int field1;
        public const int field2 = 15;
        public int field3;

        public First()
        {
            field1 = new Random().Next(0, 100);
            field3 = new Random().Next(0, 100);
        }

    }

    class Second : First
    {
        Second()
        {
            Console.WriteLine("Second - 1");
            field3 = new Random().Next(0, 100);
        }
        public Second(int [] args)
        {
            Console.WriteLine("Second - 2");
            field1 = args[0];
            field3 = args[1];
        }

        public Second(Second obj)
        {
            Console.WriteLine("Second - 3");
            field1 = obj.field1;
            field3 = obj.field3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,20};
            var second = new Second(arr);
            Console.ReadKey();
        }
    }
}
