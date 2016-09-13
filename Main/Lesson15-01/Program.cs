using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_01
{
    class Program
    {
        public delegate void DelegateName(int arg1, int arg2);
        static public void MethodPlus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static public void MethodMultiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        
        static void Main(string[] args)
        {
            Delegate del = new DelegateName(MethodPlus);
            del.DynamicInvoke(new object[] { 10, 20 });
            Console.ReadKey();
        }
    }
}
