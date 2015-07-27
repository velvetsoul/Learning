using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fuck with class Types****\n");
            Car mycar = new Car();
            mycar.petName = "Henry";
            mycar.currSpeed = 10;
            for (int i = 0; i < 10; i++)
            {
                mycar.SpeedUp(5);
                mycar.PrintState();
            }
            Car chuck = new Car();
            chuck.PrintState();
            Car mary = new Car("Mary");
            mary.PrintState();
            Car daisy = new Car("Daisy", 15);
            daisy.PrintState();
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name);
            Console.ReadLine();
        }
    }
}
