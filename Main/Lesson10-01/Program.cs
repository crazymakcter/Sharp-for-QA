using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_01
{


    class First
    {
        protected int Data;
        public First()
        {
            Data = 10;
        }
        public virtual string MakeString<T>(T value)
        {
            return (string)(value as object) + Data;
        }
    }

    class Second : First
    {
        public override string MakeString<T>(T value)
        {
            return Data.ToString() + value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            First sec = new Second();
            
            Console.WriteLine(sec.MakeString("101"));
            Console.ReadKey();
            sec = new First();

            Console.WriteLine(sec.MakeString("101"));
            Console.ReadKey();
        }
    }
}
