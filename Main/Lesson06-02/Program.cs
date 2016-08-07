using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_02
{
    /// <summary>
    /// 1. Считать строку имен с консоли от пользователя вида: Анна; Иван; Сергей; ...
    /// 2. Определить имя с максимальным количеством букв
    /// 3. Переставить найденное имя на первое место в строке
    /// 4. Обеспечить вывод измененной строки на консоль
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string - example Ann;Boris;Andrey");
            string user_str = Console.ReadLine();
            try
            {
                string[] arr_str;
                arr_str = user_str.Split(';');
                //int index_max = 0;
                int len_max = arr_str[0].Length;
                string temp = "";
                for (int i = 1; i < arr_str.Length; i++)
                {
                    if (arr_str[i].Length > len_max)
                    {
                        temp = arr_str[0];
                        arr_str[0] = arr_str[i];
                        arr_str[i] = temp;
                        len_max = arr_str[i].Length;
                    }
                }
                string res_str = "";
                foreach (string word in arr_str)
                {
                    res_str = res_str + word;
                }
                Console.WriteLine(res_str);
            }
            catch
            {
                Console.WriteLine("String incorrect, please inpute correct string");
            }
            Console.ReadKey();

        }
    }
}
