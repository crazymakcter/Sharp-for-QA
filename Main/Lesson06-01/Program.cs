using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_01
{
    /// <summary>
    /// 1. Считать строку чисел с консоли от пользователя вида: 1; 27; 13; 54; ...
    /// 2. Преобразовать строку в массив целых чисел и обработать возможные ошибки
    /// 3. Отсортировать полученный массив целых чисел по возрастанию
    /// 4. Найти в массиве сумму всех его элементов с помощью цикла foreach
    /// 5. Обеспечить отображение массива и суммы его элементов на консоль
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string with int number - Example: 27;25;0...7");
            string user_str = Console.ReadLine();
            try
            {
                string[] arr_string;
                arr_string = user_str.Split(';');
                int Len = arr_string.Length;
                int[] arr_int = new int[Len];
                int current;
                for (int a = 0; a < Len; a++)
                {

                    if (Int32.TryParse(arr_string[a], out current))
                    {
                        arr_int[a] = current;
                    }
                    else
                    {
                        // // 
                    }
                }
                Array.Sort(arr_int);
                int sum = 0;
                foreach (int b in arr_int)
                {
                    Console.Write(" " + b + " ");
                    sum = sum + b;
                }
                Console.Write("\n" + "Sum: {0}", sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }

            Console.ReadKey();
        }
    }
}
