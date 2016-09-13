using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_01
{
    class Developer : Worker
    {
        public bool Unity{get;set;}
        public bool JS{get; set;}
        public override void Action()
        {
            if (Unity)
            {
                if(JS)
                {
                    Console.WriteLine("Programming and Bug fixing on Unity & JS");
                }
                else
                {
                    Console.WriteLine("Programming and Bug fixing Unity");
                }
            }
            else
            {
                Console.WriteLine("Programming and Bug fixing JS");
            }
        }

        public void DoWork()
        {
            Console.WriteLine(String.Format("Name: {0} \n Level: {1} \n Positon: ", Name, Level));
            Action();

        }
    }
}
