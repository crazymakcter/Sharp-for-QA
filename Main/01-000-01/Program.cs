using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_000_01
{
    class Adress
    {
        public int index;
        public int Property
        {
        get 
        {
            return index; 
        }
        set
        {
            index = value; 
        }
        }

        public string country;
        public string Property
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string city;
        public string Property
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string street;
        public string Property
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string house;
        public string Property
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public string apartment;
        public string Property
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var MyAddress = new Adress();
            MyAddress.index = 61000;
            MyAddress.country = "Ukraine";
            MyAddress.city = "Kharkiv";
            MyAddress.street = "pr.Nauki";
            MyAddress.house = "11";

            Console.WriteLine("Index {0}, Country {1}, City {2}, Street {3}, House {4}", MyAddress.index, MyAddress.country, MyAddress.city, MyAddress.street, MyAddress.house);
            Console.ReadKey();
            
        }

        
    }
}
