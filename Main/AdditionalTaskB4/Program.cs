using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskB4
{
    /// <summary>
    /// 1. Найти минимальный и максимальный элементы одномерного массива целых чисел и поменять их местами.
    /// 2. Вывести результат на консоль
    /// </summary>
    class Program
    {
        static public int [] CreateRandomArray(int size)
        {
            int [] array = new int[size];
            Random rand = new Random();
            for(int i = 1; i < size; i++)
            {
                array[i] = rand.Next(0, 101);
            }
            foreach (int index in array)
            {
                Console.Write(" {0}", index);
            }
            Console.WriteLine(" ");
            return array;
        }
        static public void SearchMaxAndMinElementInArray(int[] unsortarray)
        {
            int min_index=0;
            int max_index=0;
            int min = unsortarray[0];
            int max = unsortarray[0];
            for (int b = 0; b < unsortarray.Length; b++)
            {
                if (max < unsortarray[b])
                {
                    max = unsortarray[b];
                    max_index = b;
                }
                if (min > unsortarray[b])
                {
                    min = unsortarray[b];
                    min_index = b;
                }
            }
            int temp_element;
            temp_element = unsortarray[max_index];
            unsortarray[max_index] = min;
            unsortarray[min_index] = temp_element;
            foreach (int index in unsortarray)
            {
                Console.Write(" {0}", index);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Size for array: 10");
                int size = 10;
                SearchMaxAndMinElementInArray(CreateRandomArray(size));

            }
            catch
            {
                Console.WriteLine("Incorrect size");
            }
            Console.ReadKey();

        }
    }
}
