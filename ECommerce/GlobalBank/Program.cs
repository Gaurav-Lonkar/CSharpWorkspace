using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Government;
using Policy; 
namespace GlobalBank
{

    class Program
    {

        static void BlockAcc()
        {
            Console.WriteLine("Account blocked");
        }
            
        static void Main(string[] args)
        {
            

            Taxes govt = new Taxes();
           // Account acc = new Account();
            Account accevent = new Account();

            //acc.Balance = 5000;
            //acc.Deposit(100);
            //Authority revenue = new Authority(govt.IncomeTax);
            //Authority commerce = new Authority(govt.ProfessionalTax);
            //Authority sales = new Authority(govt.GSTTax);
            //revenue();
            //commerce();
            //sales();

           // Console.WriteLine(acc.Balance);
            accevent.Overbalance+= govt.IncomeTax;
            accevent.Overbalance += govt.ProfessionalTax;
            accevent.Overbalance += govt.GSTTax;
            accevent.Underbalance += BlockAcc;

            accevent.Balance =5051;
            accevent.WithDraw(100);

            Console.WriteLine(accevent.Balance);
            Console.Read();

        }
    }
}
