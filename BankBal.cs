using System;
using System.Collections.Generic;
using System.Text;

namespace myappAug10
{   class BankAccount
    { double balance;
        public BankAccount()
        {
            this.balance = 500.0;
        }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public double getBalance()
        {
            return this.balance;
        }
    }
    class BankBal
    {
        public static void Main()
        {
            BankAccount b1 = new BankAccount(1000);
            Console.WriteLine(b1.getBalance());
        }
    }
}
