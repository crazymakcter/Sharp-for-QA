using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09_00
{
    class A
    {
        protected int _data;
        public static A operator ++(A arg)
        {
            ++arg._data;
            return arg;
        }
    }

    class B
    {
        public int _data;
        public static B operator +(B first, B second);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new A();
            var temp = ++obj;
        }
    }
}
