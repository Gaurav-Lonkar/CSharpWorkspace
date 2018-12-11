using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class _default : System.Web.UI.Page
    {


        public _default()
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                Response.Write("in get");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        public  void Onclick(object sender, EventArgs e)
        {
             String username = this.uname.Text;
            String password = this.pass.Text;

            if (username == "abc" && password == "123")
            {
                Response.Redirect("welcome.aspx");
            }
            else
            {
                this.Label1.Text = "Invalid";
               
            }
        }

        protected void forgot_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgot.aspx");
        }

        protected void On_signup(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }
    }
}