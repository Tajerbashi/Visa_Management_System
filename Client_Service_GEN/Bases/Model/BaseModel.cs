using System.ComponentModel.DataAnnotations;

namespace Client_Service_GEN.Bases.Model
{
    public interface IBaseModel
    {

    }
    public class BaseModel<T> : IBaseModel
    {
        [Key]
        public T ID { get; set; }
    }
    public class BaseModel : BaseModel<long>
    {

    }
}
