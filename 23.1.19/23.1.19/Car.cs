using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._1._19
{
    class Car
    {
        public  int year;
        public double km;
        public string brand;
        public string model;
        public string Tellmeyourmodel()
        {
            return model;
        }
        public void Drive()
        {
            Console.WriteLine("i am a car , i am driving, vroom vroom");
        }
        public void Start()
        {
            Console.WriteLine("This is the start");
        }
        public double Tellmeyourkm()
        {
            return km;
        }
    }
}
