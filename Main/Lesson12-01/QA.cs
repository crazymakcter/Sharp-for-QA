using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_01
{
    public class QA : Worker, IWorker
    {
        public bool Automation { get; set; }
        public override void Action ()
        {
            if (Automation)
            {
                Console.WriteLine("Automation and Manual Testing");
            }
            else
                Console.WriteLine("Manual Testing");
        }
        public void DoWork()
        {
            Console.WriteLine(String.Format("Name: {0} \n Level: {1} \n Positon: ", Name, Level));
            Action();

        }
    }
}
