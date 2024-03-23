namespace SSO.BaseSSO.Model
{
    public class Result<T>
    {
        public T? Data { get; set; }
        public object? Results { get; set; }
        public bool Success { get; set; }
    }
}
