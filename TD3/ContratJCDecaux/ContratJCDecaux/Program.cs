using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContratJCDecaux
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string url = "https://api.jcdecaux.com/vls/v3/";
                string data = "contracts";
                string apiKey = "ba2b09cd4738ca3173cb55816797612f74c449ba";
                HttpResponseMessage response = await client.GetAsync(url + data + "?apiKey=" + apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                List<Contract> contrats = JsonSerializer.Deserialize<List<Contract>>(responseBody);

                foreach(Contract contrat in contrats)
                {
                    Console.WriteLine(contrat.ToString());
                }

                Console.WriteLine(responseBody);


                Console.ReadLine();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
