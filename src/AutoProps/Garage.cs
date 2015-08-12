using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        public int NumberOfCars { get; set; }
        public Car myAuto { get; set; }
        public Garage()
        {
            myAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage (Car car, int number)
        {
            myAuto = car;
            NumberOfCars = number;
        }
    }
}
