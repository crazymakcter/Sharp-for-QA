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
            public double petrolTank{get;set;}
            public double speed{get;set;}
            public double fuelConsumptionPerMile;
            protected double turboBoost = 0;
            public virtual double Move(int range)
            {
                return range / speed;
            }
            public virtual void AddPetrol(int size)
            {
              
            }

            public virtual void PetrolConversion(double fuelConsumptionPerMile, double distance)
            {
            }

            public virtual bool DistanceToStopCar(double distance, bool turbo)
            {
                  if (turbo == true)
                  {
                    turboBoost = 0.5;
                  }
                  else
                  {
                    turboBoost = 0.0;
                  }
                  double distanceActual = petrolTank * fuelConsumptionPerMile * turboBoost;
                if (distance > distanceActual)
                {
                   
                  return false;
                }
                else
                {
                  PetrolConversion(fuelConsumptionPerMile, distance);
                  return true;
                }
            }


        }

        class SportCar : Transport
        {
            private double petrolTank = 43.0;
            public double petrol = 0.0;
            public bool Turbo;
            private double time = 0;
            private double fuelConsumptionPerMile = 8.00;
            //public int distanceToStop;

            public override double Move(int range)
            {

              if (Turbo == true)
              {
                time = range / (speed*1.5);
                if (DistanceToStopCar(range, true) == true)
                {
                  return time;
                }
                else
                {
                  Console.WriteLine("Please add fuel for travelling");
                  return 0;
                }
              }
              else
              {
                time = range/speed;
                if (DistanceToStopCar(range, false) == true)
                {
                  return time;
                }
                else
                {
                  Console.WriteLine("Please add fuel for travelling");
                  return 0;
                }
              }
            }

          public override void AddPetrol(int size)
          {
            if (petrolTank <= (petrol + size))
            {
              Console.WriteLine("PetrolTank is smaller than size petrol for refueling");
            }
            else
            {
              petrol = petrol + size;
            }
          }

          public override bool DistanceToStopCar(double distance, bool turbo)
          {
            double res = 0.0;
            if (turbo == true)
            {
              turboBoost = 0.5;
            }
            else
            {
              turboBoost = 1.0;
            }

            res = (petrol*fuelConsumptionPerMile)*turboBoost;
            if (distance > res)
            {
              return false;
            }
            else
            {
               PetrolConversion(fuelConsumptionPerMile, distance);
              return true;
            }
          }

          public override void PetrolConversion(double fuelConsumptionPerMile, double distance)
          {
              petrol -= (fuelConsumptionPerMile * distance) / (100 * turboBoost);
          }
        }

        static void Main(string[] args)
        {

            SportCar car = new SportCar();
            car.AddPetrol(42);
            car.Turbo = false;
            car.speed = 120;
            Console.Write("100 km: Turbo=false, Car spend {0} hour(s) - {1} km/h, {2} fuel in tank \n", car.Move(100), car.speed, car.petrol);
            car.Turbo = true;
            car.speed = 70;
            Console.Write("150 km: Turbo=true, Car spend {0} - {1} km/h, {2} fuel in tank \n", car.Move(135), car.speed, car.petrol);
            Console.ReadKey();
        }
    }
}
