using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleThread
{
    class Name
    {
        private String Fname { get; set; }
        private String Lname { get; set; }

        public Name(String fname, String lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }
        public void Run()
        {
            try
            {
                Console.WriteLine("Fname" + Fname);
                Thread.Sleep(2000);
                Console.WriteLine("Lname" + Lname);
               
            }
            catch (ThreadInterruptedException te)
            {
                Console.WriteLine(te);
            }
        }
        
    }
    class Program
    {
       


        static void Main(string[] args)
        {
            Name tn = new Name("abc", "xyx");
            Name tn1 = new Name("abc1", "xyx1");

            Thread first = new Thread(new ThreadStart(tn.Run));
            Thread last = new Thread(new ThreadStart(tn1.Run));

            first.Start();
       
            last.Start();

            Console.ReadLine();
        }
        
    }
}
