using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_01
{
    class First
    {
        public readonly int field1;
        public const int field2 = 10;
        public int field3;

        public First()
        {
            field1 = new Random().Next(0, 100);
            field3 = new Random().Next(0, 100);
        }

    }

    class Second : First
    {
        public Second()
        {
            field3 = new Random().Next(0, 100);
        }
        public Second(int args)
        {
            field3 = args;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var second = new Second();
        }
    }
}
