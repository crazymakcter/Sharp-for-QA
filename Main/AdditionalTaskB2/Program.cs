using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskB2
{
    /// <summary>
    /// 1. Создать метод, принимающий по ссылке/адресу два аргумента типа double, имеющий один выходной аргумент типа bool и 
    /// возвращающий значение типа double. 
    /// Метод имеет следующую логику работы:
    ///   - если первый double-аргумент больше второго - выходной аргумент возвращает true, 
    ///     метод возвращает результат умножения double-армунетов
    ///   - если второй double-аргумент больше первого - выходной аргумент возвращает false,
    ///     метод возвращает результат деления double-аругментов
    ///   - если первый и второй double-аргументы равны - выходной аргумент возвращает true, 
    ///     метод возвращает результат возведения в квадрат первого аргумента (используйте класс Math, метод Pow)
    /// 2. Обеспечить вызов метода таким образом, чтобы выполнились все три перечисленных условия.
    /// Результаты вызовов данного метода необходимо отобразить на Console
    /// </summary>
    class Program
    {
        static double MethodF(ref double arg1, ref double arg2, out bool arg3)
        {
            if (arg1 > arg2)
            {
                arg3 = true;
                return arg1 * arg2;
            }
            if (arg1 < arg2)
            {
                arg3 = false;
                return arg2 / arg1;
            }
            else
            {
                arg3 = true;
                return Math.Pow(arg1, 2);
            }
        }
        static void Main(string[] args)
        {
            double var1 = 10;
            double var2 = 5;
            bool var3 = true;
            Console.WriteLine("1: {0} and arg3: {1} ", MethodF(ref var1, ref var2, out var3), var3);
            var1 = 5;
            var2 = 10;
            Console.WriteLine("2: {0} and arg3: {1}", MethodF(ref var1, ref var2, out var3), var3);
            var1 = 10;
            var2 = 10;
            Console.WriteLine("3: {0} and arg3: {1}", MethodF(ref var1, ref var2, out var3), var3);
            Console.ReadKey();

        }


    }
}
