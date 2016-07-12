using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_01
{
    /// <summary>
    /// 1. Создать консольное приложеие
    /// 2. Реализовать ввод с клавиатуры двух строк
    /// 3. Отобразить результат сравнения строк
    /// 4. Отобразить результат слияния строк на основе метода string.Format()
    /// 5. Отобразить результат удаления первых 3 символов из второй строки
    /// 6. Удалить вторую строку из результата группировки строк, полученного ранее
    /// с помощью метода string.Format(). Отобразить результат операции. 6
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string firststring = Console.ReadLine();
            string secondstring = Console.ReadLine();
            Console.WriteLine("First is contains second string? " + firststring.Contains(secondstring));
            string result = string.Format("{0}{1}", firststring, secondstring);
            Console.WriteLine(result);
            Console.WriteLine("-3 synbole from second string: " + secondstring.Remove(0, 3));
            Console.WriteLine("Delete second string from result: " + result.Remove(firststring.Length));
            Console.ReadKey();
        }
    }
}
