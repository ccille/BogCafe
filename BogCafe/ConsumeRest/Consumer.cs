using BookLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeRest
{
    public class Consumer
    {
        public static string URL = "http://localhost:5165/api/Books/";

        public async Task<List<Book>> GetAllAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage respons = await client.GetAsync(URL);

                if (respons.IsSuccessStatusCode)
                {
                    List<Book> clist = await respons.Content.ReadFromJsonAsync<List<Book>>();
                    return clist;
                }
                return new List<Book>();
            }
        }

        
    }
}
