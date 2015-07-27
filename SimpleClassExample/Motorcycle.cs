using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("whooohoo");
            }
        }
        public Motorcycle()
        { }
        /*public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }*/
        public string name;
        public void SetDriverName (string name)
        {
            this.name = name;
        }
        
        public string driverName;
        
        public Motorcycle(int intensity)
        {
            SetIntensity(intensity);
        }
        public Motorcycle (int intensity, string name)
        {
            SetIntensity(intensity);
            driverName = name;
        }
        public void SetIntensity (int intensity)
        {
            if (intensity>10)
            { 
                intensity = 10; 
            }
            driverIntensity = intensity;
        }
    }
}
// безумие како-то стр.190 троелсена, разобраться с this