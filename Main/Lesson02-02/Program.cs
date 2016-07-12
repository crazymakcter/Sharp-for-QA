using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_02
{
    /// <summary>
    /// 1. В консольном приложении необходимо реализовать специфический метод
    /// 2. Метод не имеет 1 аргумент типа double и тако же тип возвращаемого значения
    /// 3. Внутри метода при использовании метода ReadLine() класса Console
    /// происходит считывание строки введенной пользователем.
    /// Данная строка передает свое значение внутренней переменной типа double.
    /// В результате работы метода возвращается частное от деления внутренней
    /// переменной на входной аргумент.
    /// 4. В Main() происходит вывод на экран результатов работы созданного метода,
    /// аргументом моторого является случаное число, полученное при
    /// использовании класса Random.
    /// </summary>
    class Program
    {
        static double Method01(double arg1)
        {
            Console.WriteLine("Enter arg:");
            double arg2 = Console.Read();
            Console.Write("Result: ");
            return arg2 / arg1;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            double rand_v = rand.Next(0, 100);
            Console.WriteLine("Random value: {0}", rand_v);
            Console.WriteLine(Method01(rand_v));
            Console.ReadKey();
        }
    }
}
