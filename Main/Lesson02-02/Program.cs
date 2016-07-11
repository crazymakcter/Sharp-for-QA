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
    /// аргументом которого является случаное число, полученное при
    /// использовании класса Random.
    /// </summary>
    class Program
    {
        static double Method(double argument)
        {
            Random par = new Random();
            double argument2 = par.Next(0, 100);
            Console.WriteLine("Random value: {0}", argument2);
            return argument / argument2;
        }
        static void Main(string[] args)
        {
            Console.Write("Value: {0}", Method(Convert.ToDouble(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
