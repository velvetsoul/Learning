using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckWithParams
{
    class Program
    {
        static void Main(string[] args)
        {
            double average;
            average = CalculateAverage(4.5, 4.60, 4, 2, 5, 6, 7, 8, 3, 46, 46, 26, 200);
            Console.WriteLine("average value is {0:f2}", average);
            EnterLogData("oh no, grid can't find data");
            EnterLogData("oh no i cant find the payroll data", "CFO");
            DisplayFancyMessage(message: "ну охуеть теперь",
                textcolor: ConsoleColor.DarkCyan, backgroundColor: ConsoleColor.DarkYellow);
            DisplayFancyMessage(textcolor: ConsoleColor.DarkMagenta, backgroundColor: ConsoleColor.DarkCyan, message: "теперь точно");

            Console.ReadLine();
        
            
        }
        static void DisplayFancyMessage (ConsoleColor textcolor, ConsoleColor backgroundColor, string message)
        {
            ConsoleColor oldcolor = Console.ForegroundColor;
            ConsoleColor oldbackgroundcolor = Console.BackgroundColor;
            Console.ForegroundColor = textcolor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldcolor;
            Console.BackgroundColor = oldbackgroundcolor;
        }
        static void EnterLogData (string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error:{0}", message);
            Console.WriteLine("Owner of Error:{0}",owner);
        }

        static double CalculateAverage (params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
            {
                
            }
        }
    }
}
