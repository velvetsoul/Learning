using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "red";
            Console.WriteLine("your car is named:{0}",c.PetName);
            c.DisplayStats();
            Garage g = new Garage();
            g.myAuto = c;
            Console.WriteLine("Number of cars:{0}",g.NumberOfCars);
            Console.WriteLine(g.myAuto.PetName);
            Console.ReadLine();
        }
    }
}
