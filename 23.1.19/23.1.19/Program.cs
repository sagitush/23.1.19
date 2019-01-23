using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._1._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mazda = new Car
            {
                year = 2012,
                km = 65000,
                brand = "mazda",
                model = "shalosh"


            };
            Console.WriteLine($"The model is:{mazda.Tellmeyourmodel()}");
            Car subaro = new Car
            {
                year = 2013,
                km =85000,
                brand = "subaro",
                model = "impreza"

            };
            Car mercedes = new Car
            {
                year = 2019,
                km = 0,
                brand = "mercedes",
                model = "AMG"

            };
            mercedes.Drive();
            Console.WriteLine($"{mercedes.brand} km is:{mercedes.Tellmeyourkm()}");
            

        }
        public static Car Bigger(Car b, Car a)
        {
            if (a.Tellmeyourkm() > b.Tellmeyourkm())
            {
                return a;
            }
            else
                return b;
         
        }
    }
}
