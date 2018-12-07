using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinalization
{
    public class DatabaseManager : IDisposable
    {
        FileStream fs;
        String Connectionstring;

        public DatabaseManager()
        {
            this.Connectionstring = "URL(MySQL/Oracle),SCHEMA,USER,PASS,";
            fs = new FileStream("db.lock", FileMode.OpenOrCreate);
        }

        public void Query(String connectiondata)
        {
            //open connection
            //firequery
            //return regult set
            //close connection
            //read from file 
            //display
        }

        void IDisposable.Dispose()
        {
            if(fs!=null)
            {
                fs.Close();
            }
        }

        ~DatabaseManager()
        {
            this.Connectionstring = String.Empty;
            fs.Close();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager dm = new DatabaseManager();
            dm.Query("SELECT * FROM TABS;");
            for (int i = 0; i < 4; i++)
            {
                //
            }
              IDisposable dsp = dm;
             dsp.Dispose();
            Console.ReadLine();
        }
    }
}
