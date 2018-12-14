using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Web.UI;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            //WriteData();
            //ReadData();
            //Interpolation();
            //ReadALLLines();
            //WriteHtml();
            //  XMLRead();

            Product p = new Product {
                Name = "Xiomi", Category = "Mobile", Price = 225};

            FileStream fs = new FileStream("products", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,p);
            fs.Close();

            Console.WriteLine("Wrote");





            Console.ReadLine();


        }
        #region
        static void WriteData()
        {
            string[] arr = new string[]
                { "Pune","Mumbai","Dubai"};
            File.WriteAllLines("city.txt", arr);

        }
        static void ReadData()
        {
            string city = File.ReadAllText("city.txt");
            Console.WriteLine(city);
        }
        static void Interpolation()
        {
            string city = "Perth";
            string country = "AUS";
            //Console.WriteLine($"City is {city} and Country is {country}");
            using (StreamWriter st = new StreamWriter("city2.txt"))
            {
                st.WriteLine($"City is {city} and Country is {country}");
            }

        }
        

        static void ReadALLLines()
        {
            string[] city = File.ReadAllLines("city2.txt");
            foreach (string c in city)
            {
                Console.WriteLine(c);
            }
        }
        static void WriteHtml()
        {
            using (StringWriter st = new StringWriter())
            using (HtmlTextWriter html = new HtmlTextWriter(st))
            {
                html.RenderBeginTag(HtmlTextWriterTag.H1);
                html.Write("Hello");
                html.RenderEndTag();
                html.RenderBeginTag(HtmlTextWriterTag.Marquee);
                html.Write("DOTNET");
                html.RenderEndTag();
                Console.WriteLine(st);
                using (StreamWriter st1 = new StreamWriter("demo.html"))
                {
                    st1.WriteLine(st);
                }

            }

        }
        static void XMLRead()
        {
            using (XmlReader reader = XmlReader.Create("demo.xml"))
            {
                while(reader.Read())
                {
                    if(reader.IsStartElement())
                    {
                        switch(reader.Name)
                        {
                            case "product":
                                Console.WriteLine();
                                break;
                            case "id":
                                Console.WriteLine("ID" + reader.ReadString());
                                break;
                            case "name":
                                Console.WriteLine("Name" + reader.ReadString());
                                break;
                        }
                    }
                }
            }
        }
        #endregion

    }
    [Serializable]
    public class Product
    {
        public String Name { get; set; }
        public String Category { get; set; }
        //[NonSerialized]
        public int Price { get; set; }
    }
  
}
