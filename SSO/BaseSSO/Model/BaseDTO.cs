namespace SSO.BaseSSO.Model
{
    public class BaseDTO<T>
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BaseDTO : BaseDTO<long>
    {

    }


}
