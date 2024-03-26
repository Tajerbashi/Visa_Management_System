using ApiCaller.Model;
using System.Net.Http.Headers;

namespace ApiCaller.Service
{
    public class CallDeleteApi(string protocol, string port, string controller, string action,string data)
    {
        private string Protocol { get => Protocol; set => Protocol = protocol; }
        private string Port { get => Port; set => Port = port; }
        private string Controller { get => Controller; set => Controller = controller; }
        private string Action { get => Action; set => Action = action; }
        private string Data { get => Data; set => Data = data; }

        public async Task CallApi(string apiKey)
        {

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:55587/");
                client.BaseAddress = new Uri($"{Protocol}:{Port}/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HttpResponseMessage response = await client.GetAsync("api/Department/1");
                HttpResponseMessage response = await client.DeleteAsync($"{Controller}/{Action}/{Data}");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Success");
                }
                else
                    Console.WriteLine("Internal server Error");
            }
        }
    }

}
