using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            SwitchExample();
            Console.ReadLine();
        }
        static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}",i);
            }
        }
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }
        static void LinqQueryOverInts()
            {
                int[] numbers = {10,20,30,40,1,2,3,8};
                var subset = from i in numbers where i < 10 select i;
                Console.WriteLine("Values in subset:");
                foreach (var i in subset)
                {
                    Console.WriteLine("{0}",i);                    
                }
            }
        static void WhileLoopExample()
        {
            string userIsDone = "";
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("in while loop");
                Console.WriteLine("are you done: [yes] [no]:");
                userIsDone = Console.ReadLine();
            }
        }
        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("in do/while loop");
                Console.WriteLine("are you done [yes] [no]");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone.ToLower() != "yes");

        }
        static void SwitchExample()
        {
            Console.WriteLine("1 [C#],2 [VB]");
            Console.WriteLine("please pick your language preference:");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
            case 1:
                Console.WriteLine("Good choice, C#");
            break;
            case 2:
                Console.WriteLine("bad choice");
            break;

            default:
                Console.WriteLine("stupid?");
            break;
              
            }
        }







    }
}
