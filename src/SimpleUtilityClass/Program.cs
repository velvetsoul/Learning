using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with static classes \n");
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
            Console.ReadLine();
        }
    }
}
