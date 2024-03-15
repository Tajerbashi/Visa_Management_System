using MainServer.Bases.Models;
using MainServer.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

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
        public GetService(string baseUrl, string serviceUrl, long id = 0)
        {
            this.BaseURL = baseUrl;
            this.ServiceUrl = serviceUrl;
        }
        public async Task<Result<T>> Invoked()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    ///Type1
                    //var response = await client.GetAsync($"{BaseURL}/{ServiceUrl}");
                    //var resResult = await response.Content.ReadAsStringAsync();
                    //var result =  JsonConvert.DeserializeObject<Result<T>>(resResult);
                    //return result;

                    ///Type2
                    client.BaseAddress = new Uri(BaseURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync(ServiceUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseResult = await response.Content.ReadFromJsonAsync<Result<T>>();
                        return responseResult;
                    }
                    return new Result<T>
                    {
                        Data = null,
                        Message = "",
                        Ressult = "",
                    };

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
    public class PostService<T> : IWebService
    {
    }
    public class PutService
    {
    }
    public class DeleteService
    {
    }
}
