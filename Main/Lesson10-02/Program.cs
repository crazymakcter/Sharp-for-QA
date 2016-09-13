using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_02
{
    public interface IFirst<T>
    {
        public string AddToString(T value);
    }

    class Second <T, E> : Interface<T> where T :T class , new() where E : struct 
    {
            
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
