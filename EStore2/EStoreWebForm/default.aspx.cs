using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using DAL;

namespace EStoreWebForm
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(int.Parse(TextBox1.Text), TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text);
            Response.Write(CustomerDAL.InsertData(c));
            
            Response.Redirect("CustomerWebForm.aspx");
        }
    }
}