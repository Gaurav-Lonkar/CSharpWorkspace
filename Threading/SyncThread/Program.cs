using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncThread
{
    class BankAccount
    {
        public string Fname { get; set; }
        public int AccNo { get; set; }
        public double Balance { get; set; }

        public BankAccount(string Fname,int accno,double balance)
        {
            this.AccNo = accno;
            this.Fname = Fname;
            this.Balance = balance;
        }
        public void Debit(double amt)
        {
            double currBal=0.0;
            try
            {
                Console.WriteLine("Current Balance is " + this.Balance);
                this.Balance = Balance - amt;
                Thread.Sleep(2000);
                Console.WriteLine("After Debit:Updated Balance is " + this.Balance);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void Credit(double amt)
        {
            double currBal = 0.0;
            try
            {
                Console.WriteLine("Current Balance is " + this.Balance);
                this.Balance = Balance + amt;
                Thread.Sleep(2000);
                Console.WriteLine("After Credit:Updated Balance is " + this.Balance);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
    enum Operation { debit,credit }
    class AccountUser
    {
        private BankAccount acc;
        private Operation op;
        private double amt;
        public AccountUser(BankAccount acc,Operation op,double amt)
        {
            this.acc = acc;
            this.op = op;
            this.amt = amt;
        }
        public void Run()
        {
            lock (acc)
            {
                if (op == Operation.debit)
                {
                    acc.Debit(amt);
                }
                else
                {
                    acc.Credit(amt);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankacc = new BankAccount("JAMES", 1001, 5000);
            AccountUser u1 = new AccountUser(bankacc, Operation.debit, 1000);
            AccountUser u2 = new AccountUser(bankacc, Operation.credit,500);
            Thread t1 = new Thread(new ThreadStart(u1.Run));
            Thread t2 = new Thread(new ThreadStart(u2.Run));
            t1.Start();
            t2.Start();
            t2.Join();
            t1.Join();
           
            Console.ReadLine();
        }
    }
}
