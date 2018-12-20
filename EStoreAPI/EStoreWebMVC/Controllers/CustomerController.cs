using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EStoreWebMVC.Models;
using System.Net.Http;
using System.Data;
using System.Net.Http.Headers;
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

            //String url = @"http://localhost:49786/";
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);
            // var customer=string.Empty;
            
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = client.GetAsync("api/Customer").Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    customer = response.Content.ReadAsStringAsync().Result;
            //   // Console.WriteLine(customer);
            //}
            //else
            //{
            //    //Console.WriteLine("{0}{1}", (int)response.StatusCode, response.ReasonPhrase);
            //}
            ////Console.ReadLine();



            List<Customer> c = new List<Customer>();

            c.Add(new Customer(20, "Kunal", "Purandare", "999996579","Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(19, "Phunal", "Purandare", "999996579","Manmad", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(20, "tunal", "Purandare", "999996579", "Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(19, "lunal", "Purandare", "999996579", "Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(20, "onal", "Purandare", "999996579", "Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(19, "runal", "Purandare", "999996579", "Manmad", "kunal@pheonix.com", "Private"));

            return View(c);
        }
        public ActionResult CDetails()
        {
            
                ViewBag.CDetails = "spaadla";
                ViewBag.Error = "ID not found";
            return View();
        }
        public ActionResult topkunal()
        {
            List<Customer> c = new List<Customer>();

            c.Add(new Customer(20, "Kunal", "Purandare", "999996579", "Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(19, "Phunal", "Purandare", "999996579", "Manmad", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(20, "tunal", "Purandare", "999996579", "Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(19, "lunal", "Purandare", "999996579", "Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(20, "onal", "Purandare", "999996579", "Pune", "kunal@pheonix.com", "Private"));
            c.Add(new Customer(19, "runal", "Purandare", "999996579", "Manmad", "kunal@pheonix.com", "Private"));

            return View(c);
        }
        public ActionResult topkunalchart()
        {
            
            return View();
        }
        public ActionResult topkunalpie()
        {
            
            return View();
        }public ActionResult allchart()
        {
            return View();
        }

    }
}