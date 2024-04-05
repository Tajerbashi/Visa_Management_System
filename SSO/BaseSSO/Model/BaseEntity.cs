namespace SSO.BaseSSO.Model
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BaseEntity : BaseEntity<long>
    {

    }

}
