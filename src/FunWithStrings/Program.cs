using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctions();
            StringConcatenation();
            EscapeChars();
            StringEquality();
            StringsAreImmutable();
            StringsAreImmutable2();
            StringBuilderFun();
            
            Console.ReadLine();
        }
        static void BasicStringFunctions()
        {
            Console.WriteLine("=>Basic strings functions");
            string firstName = "Freddy";
            Console.WriteLine("value of firstname: {0}", firstName);
            Console.WriteLine("first name has {0} letters", firstName.Length);
            Console.WriteLine("fistname in uppercase {0}", firstName.ToUpper());
            Console.WriteLine("firstname in lowercase {0}",firstName.ToLower());
            Console.WriteLine("firstname contains letter 'y'? {0}", firstName.Contains("y"));
            Console.WriteLine("firstname after replace {0}", firstName.Replace("dy"," "));
        }
        static void StringConcatenation()
        {
            Console.WriteLine(("=> String concatination:"));
            string s1 = "programming the";
            string s2 = "psychodrill (PTP)";
            string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        static void EscapeChars()
        {
            Console.WriteLine("=>Escape characters:\a");
            string strWithtabs = "model\tcolor\tspeed\tpet name\a";
            Console.WriteLine(strWithtabs);
            Console.WriteLine("everybody loves \"hello World\"\a");
            Console.WriteLine("all finished \n\n\n\n\n\a");
            Console.WriteLine(@"C:\MyApp\bin\debug");
            Console.WriteLine(@"this is my very
                                                very
                                                     very   
                                                           long string");

            Console.WriteLine();
        }
        static void StringEquality()
    {
        Console.WriteLine("=>String euality");
        string s1 = "hello!";
        string s2 = "Yo!";
        Console.WriteLine("s1 = {0}",s1);
        Console.WriteLine("s1 = {0}",s2);
        Console.WriteLine();

        Console.WriteLine("s1 == s2:{0}",s1 ==s2);
        Console.WriteLine("s1 == Hello!:{0}", s1 == "Hello!");
        Console.WriteLine("s1 == hello!:{0}", s1 == "hello!");
        Console.WriteLine("s1 == HELLO!:{0}", s1 == "HELLO!");
        Console.WriteLine("s1.equals(s2):{0}",s1.Equals(s2));
        Console.WriteLine("Yo!.equals(s2):{0}","Yo!".Equals(s2));
        Console.WriteLine();
   }
        static void StringsAreImmutable()
        {
            string s1 = "this is my String.";
            Console.WriteLine("s1 = {0}",s1);
            string upperstring = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperstring);
            Console.WriteLine("s1 = {0}",s1);
            Console.WriteLine();
        }

        static void StringsAreImmutable2()
        {
            string s2 = "My other String";
            s2 = "new string value";
            Console.WriteLine();
        }
        static void StringBuilderFun()
        {
            Console.WriteLine("=>strbuildfun:");
            StringBuilder sb = new StringBuilder("**HOLY SHIT**");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("deus ex "+"2");
            sb.AppendLine("system shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2","Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();

        }

    }
}
