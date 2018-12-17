using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BOL;

namespace DBTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers = CustomerBLL.GetAllC();
            foreach(Customer c in customers)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}
