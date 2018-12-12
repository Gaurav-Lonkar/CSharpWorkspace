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
    public class customerDAL
    {
        public static List<customer> getAll()
        {
            List<customer> custlist = new List<customer>();
            // String conString = ConfigurationManager.ConnectionStrings["conTFL"].ConnectionString;
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\batch2\CSharpWorkspace\CSharpWorkspace\EStore\DBTester\estore.mdf;Integrated Security=True";
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
                    custlist.Add(new customer(id,fname,lname,phone,email,password));
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
    }
}
