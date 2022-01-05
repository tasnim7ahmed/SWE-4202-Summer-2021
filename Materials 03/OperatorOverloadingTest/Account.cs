using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingTest
{
    internal class Account
    {
        public string ac_no;
        public string ac_holder;
        public string address;
        public int current_balance;
        public DateTime ac_opening = DateTime.Now;

        public Account()
        {

        }

        public Account(string ac_no, string ac_holder, string address, int current_balance)
        {
            this.ac_no = ac_no;
            this.ac_holder = ac_holder;
            this.address = address;
            this.current_balance = current_balance;
        }

        public void deposit(int amount)
        {
            this.current_balance += amount;
        }

        public void withdraw(int amount)
        {
            this.current_balance -= amount;
        }

        public override string ToString()
        {
            return "A/C No. : " + ac_no + "\n" + "A/C Holder : " + ac_holder + "\n" + "Current Balance : " + current_balance.ToString(); 
        }

        public static Account operator +(Account a, Account b)
        {
            Account c = new Account();
            c.current_balance = a.current_balance + b.current_balance;
            c.ac_opening = DateTime.Now;
            double diffDays = a.ac_opening.Subtract(b.ac_opening).TotalMilliseconds;

            if (diffDays>=0)
            {
                c.ac_no = a.ac_no;
                c.ac_holder = a.ac_holder;
                c.address = a.address;
            }
            else
            {
                c.ac_no = b.ac_no;
                c.ac_holder = b.ac_holder;
                c.address = b.address;
            }

            return c;
        }

        
    }
}
