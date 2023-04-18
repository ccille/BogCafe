using BookLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerRest
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

        public async Task<Book> PutAsync(int id, Book modifyBook)
        {
            using (HttpClient client = new HttpClient())
            {
                JsonContent content = JsonContent.Create(modifyBook);

                HttpResponseMessage respons = await client.PutAsync(URL + id, content);

                if (respons.IsSuccessStatusCode)
                {
                    Book retrunb = await respons.Content.ReadFromJsonAsync<Book>();
                    return retrunb;
                }

                return new Book();
            }
        }

        public async Task<Book> DeleteAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage respons = await client.DeleteAsync(URL + id);

                if (respons.IsSuccessStatusCode)
                {
                    Book retrunb = await respons.Content.ReadFromJsonAsync<Book>();
                    return retrunb;
                }

                return new Book();
            }
        }

        public async Task<Book> PostAsync(Book newbook)
        {
            using (HttpClient client = new HttpClient())
            {
                JsonContent content = JsonContent.Create(newbook);

                HttpResponseMessage respons = await client.PostAsync(URL, content);

                if (respons.IsSuccessStatusCode)
                {
                    Book retrunb = await respons.Content.ReadFromJsonAsync<Book>();
                    return retrunb;
                }

                return new Book();
            }
        }
    }
}
