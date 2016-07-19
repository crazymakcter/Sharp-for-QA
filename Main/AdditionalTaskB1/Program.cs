using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskB1
{
    /// <summary>
    /// 1. Создать перечисление с названием OperationType, имеющее возможные значения Add, Subtract, Multiply, Division
    /// 2. Содать метод, принимающий два аргумента типа double, один аргумент типа OperationType и возвращающий значение double.
    /// Проанализировать в методе значение аргумента (типа OperationType) и реализовать соответствующее действие с двумя 
    /// аргументами типа double (сложение, вычитание, умножение, деление).
    /// Результат операции метод передает в качестве возвращаемого значения
    /// 3. Вывести результаты работы созданного метод со всеми типами операций Add, Subtract, Multiply, Division и производльными 
    /// значениями double-аргументов на Console"
    /// </summary>
    class Program
    {
        enum OperationType {Add, Subtract, Multiply, Division};
        static double Calc(OperationType type, double arg1, double arg2)
        {
            double result = 0;
            switch (type.ToString())
                {
                    case "Add":
                        result = arg1 + arg2;
                        break;
                    case "Subtract":
                        result = arg1 - arg2;
                        break;
                    case "Multiply":
                        result = arg1 * arg2;
                        break;
                    case "Division":
                        result = arg1 / arg2;
                        break;
                    default:
                        Console.WriteLine("Incorrect type of operation");
                        break;
                }
            return result;

        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            double argum1 = rand.Next(-100, 100);
            double argum2 = rand.Next(-100, 100);
            Console.WriteLine("Argument 1 - {0}", argum1);
            Console.WriteLine("Argument 2 - {0}", argum2);
            Console.WriteLine("Add: ");
            Console.WriteLine(Calc(OperationType.Add, argum1, argum2));
            Console.WriteLine("Division: ");
            Console.WriteLine(Calc(OperationType.Division, argum1, argum2));
            Console.WriteLine("Multiply: ");
            Console.WriteLine(Calc(OperationType.Multiply, argum1, argum2));
            Console.WriteLine("Subtract: ");
            Console.WriteLine(Calc(OperationType.Subtract, argum1, argum2));
            Console.ReadKey();
        }
    }
}
