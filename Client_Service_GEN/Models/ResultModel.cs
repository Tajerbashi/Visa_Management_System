using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Service_GEN.Models
{
    public class ResultModel<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
