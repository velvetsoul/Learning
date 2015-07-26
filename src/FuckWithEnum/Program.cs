using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckWithEnum

{
    enum EmpType
    {
        Manager,
        Grunt,
        Contractor,
        President
    }
    class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("fuck with enums");
            EmpType emp = EmpType.President;
            EmpType e2 = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            AskForBonus(emp);
            Console.WriteLine("Emptype uses a {0}", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("emptype uses a {0}",Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine("emp is a {0}", emp.ToString());
            Console.WriteLine("{0} = {1}",emp.ToString(),(byte)emp);
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }
        static void EvaluateEnum (System.Enum e)
        {
            Console.WriteLine("information about {0}", e.GetType().Name);
            Console.WriteLine("underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("this enum has {0} members", enumData.Length);
            for (int i=0; i<enumData.Length; i++)
            {
                Console.WriteLine("name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
        }
     
        static void AskForBonus (EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("fuck off");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("fuck off");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("fuck off");
                    break;
                case EmpType.President:
                    Console.WriteLine("lick your ass");
                    break;
                default:
                    Console.WriteLine("pick smth");
                    break;

                    
            }
        }
        
    }
}
