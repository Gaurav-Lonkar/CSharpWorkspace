using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStoreWebMVC.Models
{
    public class Customer
    {
        public int id { get; set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String password { get; set; }

        public Customer()
        {

        }
        public Customer(int id, string fname, string lname, string phone, string email, string password)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            return "Id:" + this.id + " " + "Fname:" + this.fname +
                "Lname:" + this.lname + " " + "Phone:" + this.phone +
                "Email:" + this.email + " " + "Password:" + this.password;
        }
    }
}