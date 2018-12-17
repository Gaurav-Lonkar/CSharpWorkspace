using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BOL;
using BLL;

namespace EStoreRESTAPI.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        public IEnumerable<Customer> Get()
        {
            List<Customer> cust = new List<Customer>();
            cust = CustomerBLL.GetAllC();
            return cust;
        }

        // GET: api/Customer/5
        public Customer Get(int id)
        {
            Customer c = CustomerBLL.GetById(id);
            return c;
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public bool Delete(int id)
        {
            bool status = false;
            status = CustomerBLL.Delete(id);
            return status;
        }
    }
}
