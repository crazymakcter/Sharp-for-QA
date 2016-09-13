using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09_02
{
    class SomeClass
    {
        public const int sizeOfArray = 3;
        public double[] _field1;
        protected int[] _field2;

        public SomeClass()
        {
            _field1 = new double [sizeOfArray];
            _field2 = new int[sizeOfArray];
        }

        SomeClass(int[] intArray, double[] doubleArray)
        {
            _field1 = doubleArray;
            _field2 = intArray;
        }
        public double this [int indexOfArray, int indexOfElement]
        {
            get
            {
                switch(indexOfArray)
                {
                    case 0:
                        return _field1[indexOfElement];
                    case 1:
                        return _field2[indexOfElement];
                    default:
                        return -1;
                }
            }
            set
            {
                switch(indexOfArray)
                {
                    case 0:
                        _field1[indexOfElement] = value;
                        break;
                    case 1:
                        _field2[indexOfElement] = (int)value;
                        break;
                    default:
                        break;
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new SomeClass();
            obj._field1[0] = 154;

        }
    }
}
