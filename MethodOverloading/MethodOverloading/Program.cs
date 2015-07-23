using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10,100));
            Console.WriteLine(Add(58921244441453637, 12222222241565656565));
            Console.WriteLine(Add(4.3,3));
            Console.ReadLine();
        }
        static int Add (int x, int y)
        { return x + y; }
        static double Add(double x, double y)
        {return x+y;}
        static long Add(long x, long y)
        {return x+y;}
    }
}
