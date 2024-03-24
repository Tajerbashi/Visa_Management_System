namespace SSO.BaseSSO.Model
{
    public class BaseView<T>
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BaseView : BaseView<long>
    {

    }

}
