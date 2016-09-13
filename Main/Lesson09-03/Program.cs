using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09_03
{
    public static class ExtemsionClass
    {
        pu
        public static float NewPercent (this Random obj)
        {
            obj.Some = new Random();
            return obj.Next(0, 100);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Percent: ");
            Console.WriteLine(ExtemsionClass.NewPercent);
        }
    }
}
