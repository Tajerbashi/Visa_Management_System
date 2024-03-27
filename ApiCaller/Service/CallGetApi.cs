using ApiCaller.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApiCaller.Service
{
    public class CallGetApi(string protocol, string api)
    {
        private string Protocol { get => protocol; set => Protocol = protocol; }
        private string API { get => api; set => API = api; }

        public async Task CallApi(string apiKey)
        {

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:55587/");
                client.BaseAddress = new Uri($"{Protocol}/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HttpResponseMessage response = await client.GetAsync("api/Department/1");
                HttpResponseMessage response = await client.GetAsync($"{API}");
                if (response.IsSuccessStatusCode)
                {
                    Result<object> res = await response.Content.ReadFromJsonAsync<Result<object>>();
                    Console.WriteLine("Result : {0}", res);
                }
                else
                    Console.WriteLine("Internal server Error");
            }
        }
    }

}
