namespace Database.Server.Bases.Models
{
    public class Result<T>
    {
        public T? Data { get; set; }
        public object Ressult { get; set; }
        public string Message { get; set; }
    }
}
