using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCaller.Model
{
    public class ApiModel(string port, string controller, string action)
    {
        public string Port { get => Port; set => Port = port; }
        public string Controller { get => Controller; set => Controller = controller; }
        public string Action { get => Action; set => Action = action; }

        public string GetApi()
        {
            return ($"{port}/{controller}/{action}");
        }
    }
}
