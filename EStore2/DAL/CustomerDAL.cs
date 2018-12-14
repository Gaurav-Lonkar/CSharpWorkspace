using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BOL;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class CustomerDAL
    {
        public static string constring = string.Empty;
        static CustomerDAL()
        {
            constring = ConfigurationManager.ConnectionStrings["conTFL"].ConnectionString;
           // constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\batch2\CSharpWorkspace\CSharpWorkspace\EStore2\TestaLL\estore.mdf; Integrated Security = True";
        }

        public static List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = constring;
            string query = "SELECT * FROM CUSTOMERS";
            SqlCommand cmd = new SqlCommand(query, con as SqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow drow in dt.Rows)
                {
                    int id = int.Parse(drow["Id"].ToString());
                    string fname = drow["fname"].ToString();
                    string lname = drow["lname"].ToString();
                    string email = drow["email"].ToString();
                    string password = drow["password"].ToString();
                    string phone = drow["phone"].ToString();

                    Customer cust = new Customer(id, fname, lname, phone, email, password);
                    customers.Add(cust);
                }
            }catch(SqlException e)
            {
                string expmsg = e.Message;
            }
            finally
            {
                con.Close();
            }
            return customers;
        }

        public static bool InsertData(Customer cust)
        {

            bool status = false;
            IDbConnection con = new SqlConnection();
            con.ConnectionString = constring;
            string query = "SELECT * FROM CUSTOMERS";
            IDbCommand cmd = new SqlCommand();
            cmd.Connection = con as SqlConnection;
            cmd.CommandText = query;

            
            SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
            DataSet ds = new DataSet();

            try
            {

                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Fill(ds);
                DataRow newrow = ds.Tables[0].NewRow();
                newrow["Id"] = cust.id;
                newrow["fname"] = cust.fname;
                newrow["lname"] = cust.lname;
                newrow["phone"] = cust.phone;
                newrow["email"] = cust.email;
                newrow["password"] = cust.password;



                ds.Tables[0].Rows.Add(newrow);
                da.Update(ds);
                status = true;

            }
            catch (Exception e)
            {
                string excMessage = e.Message;
            }
            return status;

        }

        public static bool DeleteData(int id)
        {
            IDbConnection con = new SqlConnection();
            con.ConnectionString = constring;
            string query = "DELETE FROM CUSTOMERS WHERE Id="+id;
            IDbCommand cmd = new SqlCommand();
            cmd.Connection = con as SqlConnection;
            cmd.CommandText = query;


            SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
            DataSet ds = new DataSet();
            d
        }


    }
        
}
