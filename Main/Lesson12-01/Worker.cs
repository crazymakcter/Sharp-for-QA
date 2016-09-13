using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_01
{
    public abstract class Worker
    {
        public string Name;
        public int Level;
        public abstract void Action();

        public static Worker operator ++(Worker obj)
    {
        obj.Level++;
        return obj;
    }
    }
}
