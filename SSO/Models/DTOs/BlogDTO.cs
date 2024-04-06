using SSO.BaseSSO.Model;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace SSO.Models.DTOs
{
    public class BlogDTO : BaseDTO
    {
        [Required(ErrorMessage = "عنوان الزامی است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "توضیحات الزامی است")]
        public string Description { get; set; }
        [Required(ErrorMessage = "محتوا الزامی است")]
        public string Body { get; set; }
        public string UserName { get; set; }

        public int Like { get; set; }

        public int Share { get; set; }

        public long UserId { get; set; }
        public UserDTO User { get; set; }

        public ClaimsPrincipal CurrentUser { get; set; }
    }
}
