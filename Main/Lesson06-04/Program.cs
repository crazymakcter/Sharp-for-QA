using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson06_04
{

  /// <summary>
  /// 1 Создать прямоугльный двумнрый массив целых чисел 10 на 10
  /// 2 Заполнить массив возрастающими значениями в следующем порядке:
  /// 3 Обеспечить отображение массива на консоль
  /// </summary>
 
  class Program
  {
    static public void CreateAndFillArray()
    {
      Console.WriteLine("Create array [10,10]");
      int[,] array = new int[10, 10];
      int numberOfElementsInDiagonal;
      int lend = 10;
      for (int indexInLine = lend-1; indexInLine != 0; --indexInLine)
      {
        for (int indexInColumn = 0; indexInColumn < lend; ++indexInColumn)
        {
          numberOfElementsInDiagonal = (indexInLine + indexInColumn + 1); // считаем число элементов в диагонали, которой принадлежит элемент array[i][j]
          if (numberOfElementsInDiagonal > lend) // если условие выполняется, то элемент array[i][j] находится под главной диагональю
          {
            numberOfElementsInDiagonal = 2 * lend - (indexInLine + indexInColumn + 1); // правильно пересчитываем число элементов в диагонали
            array[indexInLine,indexInColumn] = indexInColumn + (lend - 1) * (lend - 2) / 2 - numberOfElementsInDiagonal * (numberOfElementsInDiagonal - 1) / 2 + 10 * (10 + 1) / 2;
              /*
                j - номер элемента в диагонали
                (s - 1)*(s - 2) / 2 - numberOfElementsInDiagonal*(numberOfElementsInDiagonal - 1) / 2 - количество элементов между главной диагональю и текущей диагональю
                s*(s + 1) / 2 - количество элементов от первого элемента до главной диагонали включительно
                (верхний треугольник, у которого гипотенуза идёт по главной диагонали матрицы). Для s = 9 будет 45
              */
          }
          else
          {
            array[indexInLine,indexInColumn] = numberOfElementsInDiagonal - indexInLine + numberOfElementsInDiagonal * (numberOfElementsInDiagonal - 1) / 2;
              /*
                numberOfElementsInDiagonal - i - номер элемента в диагонали
                numberOfElementsInDiagonal*(numberOfElementsInDiagonal - 1) / 2 - количество элементов между первым элементом(диагональю из первого элемента) и текущей диагональю
              */
          }

          Console.Write(" {0}", array[indexInLine,indexInColumn]);
        }
        Console.WriteLine("\n");
      }
     
    }
    static void Main(string[] args)
    {
      CreateAndFillArray();
      Console.ReadKey();
    }
  }
}
