namespace SSO.BaseSSO.Model
{
    public class Result<TData,TResult>
    {
        public TData Data { get; set; }
        public TResult Results { get; set; }
        public string Messages { get; set; }
        public bool Success { get; set; }
    }
}
