using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingAccount(double balance)
        {
            currBalance = balance;
        }
        public static void SetInterstRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
        
    }
}
