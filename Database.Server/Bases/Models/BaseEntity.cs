using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Server.Bases.Models
{
    public interface IBaseEntity
    {
    }
    public abstract class BaseEntity<T> : IBaseEntity
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T ID { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
    public abstract class BaseEntity: BaseEntity<long>
    {

    }
}
