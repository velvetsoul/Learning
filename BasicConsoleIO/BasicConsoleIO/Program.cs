using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Basic Console I/O**********");
                GetUserData();
                Console.ReadLine();
        }

        static void GetUserData()
       {
        Console.Write("Please enter your name");
        string UserName = Console.ReadLine();
        Console.Write("Please enter your age");
        string UserAge = Console.ReadLine();
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hello {0} you are {1} years old.", UserName, UserAge);
        Console.ForegroundColor = prevColor;
       }

    }
}

