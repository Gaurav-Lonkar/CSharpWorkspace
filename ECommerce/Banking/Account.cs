using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Policy;
namespace Banking
{
    public class Account
    {
        int balance;

        public event Authority Underbalance;
        public event Authority Overbalance;

        public int Balance
        {
            get { return balance; }
            set {
                if (value < 100)
                {
                    Underbalance();
                }
                if(value > 5050)
                {
                    Overbalance();
                }

                this.balance = value; }
        }
        public void Deposit(int amount)
        {
            this.balance += amount;
        }
        public void WithDraw(int amount)
        {
            this.balance -= amount;
        }
    }
}
