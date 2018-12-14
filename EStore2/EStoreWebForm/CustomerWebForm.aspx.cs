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
    public partial class CustomerWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // List.DataSource = CustomerDAL.GetAll();
           // List.DataBind();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List.DataSource = CustomerDAL.GetAll();
           // List.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // List.DataSource = CustomerDAL.GetAll();
            //  List.DataBind();
           GridView1.DataSource = CustomerDAL.GetAll();
            GridView1.DataBind();
        }

        protected void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            Response.Write(i);
        }
    }
}