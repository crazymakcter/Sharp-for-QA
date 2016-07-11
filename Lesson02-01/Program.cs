using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_01
{
    /// <summary>
    /// 1. В консольном приложении необходимо реализовать 2 метода
    /// 2. Метод 1: принимает два аргумента типа int и возвращает их сумму
    /// 3. Метод 2: принимает по ссылке два аргумента типа int.
    /// Если первый аргумент больше второго - метод возвращает их произведение.
    /// В противном случае, если второй аргумент больше первого - метод
    /// Увеличивает первый аргумент на 10 и возвращает частное от их деления.
    /// 4. В главном методе создается две переменные, типа int и инициализируются
    /// случаными значениями, полученными при использовании класса Random.
    /// Необходимо вывести на консоль результат работы методов таким образом,
    /// чтобы первым аргументом метода1 был результат работы метода2.
    /// </summary>
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
