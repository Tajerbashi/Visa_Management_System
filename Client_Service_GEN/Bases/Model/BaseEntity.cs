using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Service_GEN.Bases.Model
{
    public interface IBaseEntity
    {

    }
    public class BaseEntity<T> : IBaseEntity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateData { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BaseEntity : BaseEntity<long>
    {
    }
}
