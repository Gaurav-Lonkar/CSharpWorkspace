using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
   public  class customer
    {
        int id { get; set; }
        String fname { get; set; }
        String lname { get; set; }
        String phone { get; set; }
        String email { get; set; }
        String password { get; set; }

        public customer()
        {

        }
        public customer(int id, string fname,string lname,string phone,string email,string password )
        {
            this.id=id;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            return "Id:"+this.id+" "+"Fname:"+this.fname+
                "Lname:" + this.lname + " " + "Phone:" + this.phone+
                "Email:" + this.email + " " + "Password:" + this.password;
        }




    }
}
