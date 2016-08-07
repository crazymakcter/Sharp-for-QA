using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_01
{
    /// <summary>
    /// 1. Создать два одномерных массива случайных чисел по 20 элементов
    /// 2. Обеспечить отображение данных массивов на консоль
    /// 3. Создать третий одномерный массив из первых двух, таким образом, чтобы из
    /// каждых его 4 элементов первые два были элементами второго массива, а
    /// третий и четверный - были элементами первого массива
    // 4. Обеспечить отображение третьего массива на консоль
    // 5.  Отсортировать третий массив по убыванию и вывести на консоль
    /// </summary>
    class Program
    {
        public static int[] CreateRandomaArray(int size)
        {
            Random rand = new Random();
            int[] randomarray = new int[size];
            for (int index = 0; index < randomarray.Length; index++)
            {
                randomarray[index] = rand.Next(0, 100);
            }
            return randomarray;
        }
        static void Main(string[] args)
        {
            const int sizeOfArray20 = 20;
            const int sizeOfArray40 = 40;
            int[] array_1 = CreateRandomaArray(sizeOfArray20);
            int[] array_2 = CreateRandomaArray(sizeOfArray20);
            int[] array_3 = new int[40];
            int temp_index = 0;
            for (int y = 0; temp_index < sizeOfArray40 && y < sizeOfArray20; y += 2)
            {

                array_3[temp_index] = array_1[y];
                array_3[temp_index + 1] = array_1[y + 1];
                array_3[temp_index + 2] = array_2[y];
                array_3[temp_index + 3] = array_2[y + 1];
                temp_index = temp_index + 4;
                //y = y++;
            }
            foreach (int a in array_1)
            {
                Console.Write(a + " ");

            }
            Console.Write("\n");
            foreach (int b in array_2)
            {
                Console.Write(b + " ");
            }
            Console.Write("\n");
            foreach (var i in array_3)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
