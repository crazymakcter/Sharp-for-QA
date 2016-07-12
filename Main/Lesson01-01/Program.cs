using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_01
{
    class Program
    {
        /// <summary>
        /// Создайте консольное приложение
        /// 1. В главном методе с помощью оператора new создайте объект типа Random
        /// 2. Вызовите от созданного объекта метод генерации случайных чисел Next(0, 100)
        /// 3. Используя оператор if-else или ? : проанализируте сгенерированное значение
        /// следующим образом:
        /// - если оно больше 60 - необходимо вывести строку “БОЛЬШЕ”
        /// - если оно меньше или равно 60 и не больше 30 - вывести это значение на экран
        /// - если оно меньше 30 -необходимо отобразить строку “МЕНЬШЕ”
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random test_random = new Random();
            int min = 0;
            int max = 100;
            int my_random = test_random.Next(min, max);
            if (my_random > 60)
            {
                Console.WriteLine("More");
            }
            else if (my_random <= 60 && my_random > 30)
            {
                Console.WriteLine(my_random);
            }
            else
            {
                Console.WriteLine("Less");
            }

            Console.WriteLine("Hello Word");
            Console.ReadKey();
        }
    }
}
