using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This stupid name like blah blah blah fun with type converstions(he calls it fun)\a");
            short numb1 = 9; short numb2 = 1;
            Console.WriteLine("{0}+{1}={2}",numb1,numb2,Add(numb2,numb1));
            Console.ReadLine();

        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
