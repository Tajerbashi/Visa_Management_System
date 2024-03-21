using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Domain_Library.BaseDomain
{
    public interface IBaseEntity
    {

    }
    public abstract class BaseEntity<TKey> : IBaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public TKey ID { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateData { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<long>
    {

    }
}
