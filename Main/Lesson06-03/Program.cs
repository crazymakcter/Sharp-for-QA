using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_03
{
    /// <summary>
    /// 1. Создать прямоугльный двумнрый массив случайных чисел 10 на 10
    /// 2. Нати суммы эленемтов массива, расположенных по диагонали:
    /// 3. Обеспечить вывод на консоль массива и найденных сумм диагональных
    /// элементов
    /// </summary>
    class Program
    {
        
        static public int[,] CreateAndFillArray()
        {
            Random rand_val = new Random();
            Console.WriteLine("Create array [10,10] with random value");
            int[,] array = new int[10,10];
            for(int i = 0;  i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    array[i, j] = rand_val.Next(0, 100);
                    Console.Write(array[i,j] + "\t");
                }
                Console.Write('\n');

            }
            return array;
        }

        static public void FoundSummDiagonalsArray(int[,] array_summ)
        {
            int summ = 0;
            for(int i = 0;  i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if ((i == j))
                    {
                        //Console.WriteLine(summ);
                        summ = summ + array_summ[i, j];
                        //Console.Write(array_summ[i, j] + " ");
                    }
                    if((i + j) == 9)
                    {
                        summ = summ + array_summ[i,j];
                    }
                    
                }
                

            }
            Console.Write("Summ: ");
            Console.Write(summ);
        }
            
        static void Main(string[] args)
        {

            FoundSummDiagonalsArray(CreateAndFillArray());
            Console.ReadKey();
            
        }
    }
}
