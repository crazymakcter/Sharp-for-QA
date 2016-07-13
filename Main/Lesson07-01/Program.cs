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
            public double Move(int range)
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
            
            car.Turbo = true;
            
            Console.Write(car.Move(500));
        }
    }
}
