using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace DBTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<customer> customers = new List<customer>();
            customers = customerDAL.getAll();
            foreach(customer c in customers)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}
