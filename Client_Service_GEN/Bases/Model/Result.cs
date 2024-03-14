namespace Client_Service_GEN.Bases.Model
{
    public class Result<T>
    {
        public T Data { get; set; }
        public object Model { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
