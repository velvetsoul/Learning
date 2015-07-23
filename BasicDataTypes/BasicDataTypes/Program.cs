using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
            {
            UseBigInteger();
            Console.ReadLine();
            }
        static void UseBigInteger()
            {
                Console.WriteLine("=>use big int");
                BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999999999999999999999999999999998");
                Console.WriteLine("Value of biggy is^ {0}", biggy);
                Console.WriteLine("is biggy an even value: {0}", biggy.IsEven);
                Console.WriteLine("is biggy a power of two? {0}", biggy.IsPowerOfTwo);
                BigInteger reallybig = BigInteger.Multiply(biggy, BigInteger.Parse("9999999999916748916581946293590871305"));
                Console.WriteLine("value of reallybig is {0}", reallybig);
                Console.WriteLine();
             
            }
        
    }
}
