﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
           DeclareImplicitVars();
           LinqQueryOverInts();
           Console.ReadLine();
        }
        static void DeclareImplicitVars()
        {
            Console.WriteLine("implicit types");
            var myInt = 0;
            var myBool = true;
            var myString = "Times, marches on";
            Console.WriteLine("myInt is a {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a {0}", myString.GetType().Name);
        }
        static void LinqQueryOverInts()
        {
            int[] numbers = {10,20,30,40,1,2,3,8};
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset");
                foreach (var i in subset)
                {
                    Console.WriteLine("{0}",i);
                }
            Console.WriteLine();
            Console.WriteLine("subset is a: {0}",subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
	{
		 
	}
        }
    }
}
