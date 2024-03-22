namespace Domain_Driven_Design_Solution.Library_Domain.Base
{
    public class BaseEntity<TKey>
    {
        public TKey ID { get; set; }
    }
    public class BaseEntity : BaseEntity<long>
    {
    }
}
