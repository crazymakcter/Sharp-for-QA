using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_01
{
    /// <summary>
    /// 1. Создать ломаный массив целых чисел 6 строк на 5 столбцов
    /// 2. Заполнить массив случайными значениями
    /// 3. Найти в каждой строке данного массива минимальный элемент и поставить его
    /// на первую позицию данной строки 3
    /// 4. Определить значения минимального и максимального элементов массива
    /// 5. Обеспечить вывод массива на консоль
    /// 6. Обеспечить вывод на консоль знечений минимального и максимального
    /// элементов
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int row = 5;
            const int col = 6;
            int min = 0;
            int max = 0;
            int[][] arr = new int[row][];
            Random test = new Random();
            int global_min = 100;
            int global_max = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                arr [i] = new int[col];
                for(int e = 0; e < col; e++)
                {
                    arr[i][e] = test.Next(0, 100);
                    Console.Write(arr[i][e] + "\t");

                }
                Console.Write("\n");
                
            }
            Console.Write("\n");
            for (int a = 0; a < row; a++)
            {
                min = arr[a][0];
                max = arr[a][0];
                for (int b = 0; b < col; b++)
                {
                    if (max < arr[a][b])
                    {
                        max = arr[a][b];
                        if (global_max < max)
                        {
                            global_max = max;
                        }
                    }
                    if (min > arr[a][b])
                    {
                        min = arr[a][b];
                        arr[a][b] = arr[a][0];
                        arr[a][0] = min;
                        if (global_min > min)
                        {
                            global_min = min;
                        }
                        
                    }
                    
                    
                }
                arr[0][0] = min;
            }
            for (int d = 0; d < row;d++ )
            {
                for(int r = 0; r < col; r++)
                {
                    Console.Write(arr[d][r] + "\t");
                }
                Console.Write("\n");
            }
                Console.WriteLine("Min: {0}" + " Max: {1}", global_min, global_max);
            Console.ReadKey();
        }
    }
}
