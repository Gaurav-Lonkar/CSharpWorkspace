using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EStoreWebMVC.Models;
namespace EStoreWebMVC.Controllers
{
    public class CustomerController : Controller
    {
       // Customer cust;
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            //cust = new Customer(20, "Kunal", "Purandare", "999996579", "kunal@pheonix.com", "Private");
            // ViewBag.Customer= cust;
            // return View();
            List<Customer> c = new List<Customer>();

            c.Add(new Customer(20, "Kunal", "Purandare", "999996579", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(19, "Phunal", "Purandare", "999996579", "kunal@pheonix.com", "Private"));

            return View(c);
        }
        public ActionResult CDetails()
        {
            
                ViewBag.CDetails = "spaadla";
                ViewBag.Error = "ID not found";
            return View();
        }
    }
}