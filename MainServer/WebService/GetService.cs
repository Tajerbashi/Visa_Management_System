using MainServer.Bases.Models;
using System.Net;

namespace MainServer.WebService
{
    public interface IWebService
    {

    }
    public class GetService<T> : IWebService
        where T : class
    {
        private string BaseURL { get; set; }
        public GetService(string baseurl, long id = 0)
        {
            if (id != 0)
            {
                baseurl = $"{baseurl}/{id}";
            }
            else
            {
                this.BaseURL = baseurl;
            }
        }
        public Result<T> Call()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            var response = client.GetAsync("todos/1").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var Result = System.Text.Json.JsonSerializer.Deserialize<Result<T>>(responseContent);
                Console.WriteLine("Get successful!");
                return Result;
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
                return new Result<T>
                {
                    Data = null,
                    Ressult = "",
                    Message = "",
                };
            }
        }
    }
    public class PostService
    {
    }
    public class PutService
    {
    }
    public class DeleteService
    {
    }
}
