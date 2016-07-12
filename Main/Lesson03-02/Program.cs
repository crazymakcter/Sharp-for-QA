﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_02
{
    /// <summary>
    /// 1. Создать консольное приложение
    /// 2. В приложении создать ломанный массив челых чисел 4 на 4
    /// 3. Поочередно заполнить массив значениями в порядке обхода его элементов.
    /// При заполнении массива значениями каждый элемент должен быть на 1
    /// Порядок обхода и заполнения элементов указывается ниже
    /// 4 Вывести массив на экран
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[][] arr = new int[4][];
            for (int i = 0; i < 4; ++i)
            {
                arr[i] = new int[4];
                if (i % 2 < 0)
                {

                    for (int y = 0; y < 4; ++y)
                    {

                        arr[i][y] = sum;
                        Console.WriteLine(arr[i][y] + "  ");
                        sum = sum + 1;
                    }
                }
                else
                {
                    for (int z = 3; z > 0; z--)
                    {
                        arr[i][z] = sum + 1;
                        Console.WriteLine(arr[i][z] + "  ");
                        sum = sum + 1;
                    }
                }
                Console.WriteLine("\n");

            }

            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Console.WriteLine(arr[a][b] + "  ");

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
    }
}
