using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
namespace EStoreRESTClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = @"http://localhost:49786/";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Customer").Result;
            if (response.IsSuccessStatusCode)
            {
                var customer = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(customer);
            }
            else
            {
                Console.WriteLine("{0}{1}", (int)response.StatusCode, response.ReasonPhrase); 
            }
            Console.ReadLine();
        }
    }
}
