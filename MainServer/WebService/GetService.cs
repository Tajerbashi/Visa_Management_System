using MainServer.Bases.Models;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace MainServer.WebService
{
    public interface IWebService
    {

    }
    public class GetService<T> : IWebService
        where T : class
    {
        private string BaseURL;
        private string ServiceUrl;
        public GetService(string baseUrl,string serviceUrl, long id = 0)
        {
            this.BaseURL = baseUrl;
            this.ServiceUrl = serviceUrl;
        }
        public async Task<Result<T>> Call()
        {
            var Result = new Result<T>();
            // HTTP GET.  
            using (var client = new HttpClient())
            {
                // Setting Base address.  
                client.BaseAddress = new Uri(BaseURL);

                // Setting content type.  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Initialization.  
                HttpResponseMessage response = new HttpResponseMessage();

                // HTTP GET  
                response = await client.GetAsync(ServiceUrl).ConfigureAwait(false);

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    // Reading Response.  
                    string result = response.Content.ReadAsStringAsync().Result;
                    Result = JsonConvert.DeserializeObject<Result<T>>(result);
                }
            }
            return Result;

        }
    }
    public class PostService<T>: IWebService
    {
    }
    public class PutService
    {
    }
    public class DeleteService
    {
    }
}
