using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs2013Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureCUI();
            Console.ReadLine();
            
        }
         
        private static void ConfigureCUI()
        {
            Console.Title = "my Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************");
            Console.WriteLine("*************Welcome To hell***************");
            Console.WriteLine("*******************************************");
            Console.BackgroundColor = ConsoleColor.Black;         
        }
    }
}
