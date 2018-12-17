using System;
using System.Collections.Generic;
using System.Linq;
using BOL;
using DAL;

//BI
//LINQ --------C# Programing

namespace BLL
{
    public class CustomerBLL
    {

        public static List<Customer> GetAllC()
        {
            //List<Customer> Customers = GetAllCustomers();
            List<Customer> customers = CustomerDAL.GetAll();
            return customers;
        }
        public static Customer GetById(int id)
        {
            //List<Customer> Customers = GetAllCustomers();
            Customer customer = CustomerDAL.GetById(id);
            return customer;
        }
        public static bool Delete(int id)
        {
            bool status = false;
            status=CustomerDAL.Delete(id);
            return status;
        }
    }
}
