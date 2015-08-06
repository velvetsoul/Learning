using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with employee\n");
            Employee emp = new Employee("marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();
            emp.Name="Marv";
            Console.WriteLine("employee is named:{0}",emp.Name);
            Employee joe = new Employee();
            joe.Age++;
            Console.ReadLine();
        }
    }
}
