using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }
        public Employee (string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = Age;
            Pay = pay;
            empSSN = ssn;
        }
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}\nID: {1}\nAge: {2}\nPay: {3}", Name, ID, Age, Pay);
        }
        public string SocialSecurityNumber
        {
            get { return empSSN;}
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get {return Name;}
            set
            {
                if (value.Length >15)
                    Console.WriteLine("Error! too much letters");
                else
                    Name = value;
            }
        }
        public int ID
        {
            get{return ID;}
            set{ID=value;}
        }
        public float Pay
        {
            get{return Pay;}
            set{Pay = value;}
        }        
    }
}
