using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_01
{
    class Team<T>  where T : Worker, IWorker
    {
        private T[] _team;
        public Team()
        { 
        T[] _team = new T [10];
        }
        public int Size 
        { 
            get
            {
                return _team.Count();
            } 
        }
        public void TeamWork()
        {
            foreach(var person in _team)
            {
                person.DoWork();
            }
        }

       public void Add(T obj)
        {
           if (Size<10)
           {
               _team[Size] = obj;
           }
        }
        public void RemoveByName(string name)
       {
           _team = _team.Where(val => val != name).ToArray;
       }

    }
}
