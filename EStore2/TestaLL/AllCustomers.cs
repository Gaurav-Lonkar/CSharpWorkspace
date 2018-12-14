using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace TestaLL
{
    class AllCustomers
    {
        static void Main(string[] args)
        {
            /* List<Customer> AllCust = CustomerDAL.GetAll();
             foreach (Customer c in AllCust)
             {
                 Console.WriteLine(c);
             }*/
            Customer c = new Customer(51, "abc", "xyz", "123456", "abc123@gmail.com", "123");
          
            if (CustomerDAL.InsertData(c))
            {
                Console.WriteLine("inserted");
            }
            Console.ReadLine();
                
        }
    }
}
