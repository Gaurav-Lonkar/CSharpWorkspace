using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 
using BOL;
namespace DAL
{
    public class CustomerDAL
    {
        public static List<Customer> GetAll()
        {
            List<Customer> custlist = new List<Customer>();
            String conString = ConfigurationManager.ConnectionStrings["conTFL"].ConnectionString;
           // String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\batch2\CSharpWorkspace\CSharpWorkspace\EStoreAPI\DBTest\estore.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            String query = "SELECT * FROM customers;";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  int id=int.Parse(reader["id"].ToString());
                  String fname= (reader["fname"].ToString());
                    String lname = (reader["lname"].ToString());
                    String email = (reader["email"].ToString());
                    String password = (reader["password"].ToString());
                    String phone = (reader["phone"].ToString());
                    custlist.Add(new Customer(id,fname,lname,phone,email,password));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();

            }
            return custlist;
        }
        public static Customer GetById(int id1)
        {
            Customer c=null;
            String conString = ConfigurationManager.ConnectionStrings["conTFL"].ConnectionString;
            // String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\batch2\CSharpWorkspace\CSharpWorkspace\EStoreAPI\DBTest\estore.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            String query = "SELECT * FROM customers where id="+id1;
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    String fname = (reader["fname"].ToString());
                    String lname = (reader["lname"].ToString());
                    String email = (reader["email"].ToString());
                    String password = (reader["password"].ToString());
                    String phone = (reader["phone"].ToString());
                    c = new Customer(id, fname, lname, phone, email, password);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();

            }
            return c;
        }
        public static bool Delete(int id1)
        {
            bool status = false;
            String conString = ConfigurationManager.ConnectionStrings["conTFL"].ConnectionString;

            SqlConnection con = new SqlConnection(conString);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\batch2\CSharpWorkspace\CSharpWorkspace\EStoreAPI\DBTest\estore.mdf;Integrated Security=True";
                String query = "DELETE FROM customers where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add(new SqlParameter("@id", id1));
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
                status = true;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();

            }
            return status;
        }
    }
}
