using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSO.BaseSSO.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Domains
{
    [Table("Blogs", Schema = "Security"), Description("وبلاگ کاربران")]
    public class BlogEntity : BaseEntity
    {
        [Description("عنوان")]
        public string Title { get; set; }
        [Description("توضیحات")]
        [Required]
        public string Description { get; set; }
        [Description("محتوا")]
        [Required]
        public string Body { get; set; }
        [Description("پسندیده ها")]
        [Required]
        public int Like { get; set; }
        [Description("اشتراک گذاری ها")]
        [Required]
        public int Share { get; set; }

        [ForeignKey(nameof(UserEntity))]
        public long UserId { get; set; }
        public UserEntity UserEntity{ get; set;}
    }

    public class BlogConfiguration : IEntityTypeConfiguration<BlogEntity>
    {
        public void Configure(EntityTypeBuilder<BlogEntity> builder)
        {
            builder.HasOne(x => x.UserEntity)
                .WithMany(y => y.BlogEntities)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
