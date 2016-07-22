using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessom07_01
{
    class Program
    {
        interface IMoveable
        {   
          double Move(int range);
        }

        class Transport : IMoveable
        {
            public int speed{get;set;}
            public int petrol{get;set;}
            protected int fuelConsumptionPerMile;
            virtual public double Move(int range)
            {
                return range / speed;
            }
            public void AddPetrol(int size)
            {
                petrol = petrol + size;
            }      

        }

        class SportCar : Transport
        {
            public bool Turbo;
            override public double Move(int range)
            {
                if (Turbo == true)
                    {
                        return range / (speed * 1.5);
                    }
                else
                {
                    return range / speed;
                }
            }
        }

        static void Main(string[] args)
        {
            SportCar car = new SportCar();
            
            car.Turbo = false;
            car.speed = 120;
            Console.Write("Turbo=fale, Car spend {0} on {1} km \n", car.Move(500), car.speed);
            car.Turbo = true;
            car.speed = 120;
            Console.Write("Turbo=true, Car spend {0} on {1} km \n", car.Move(500), car.speed);
            Console.ReadKey();
        }
    }
}
