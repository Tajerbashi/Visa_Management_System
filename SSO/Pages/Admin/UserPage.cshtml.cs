using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.Admin
{
    public class UserPageModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public UserPageModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public List<UserDTO> Users { get; set; }
        public void OnGet()
        {
            Users = new List<UserDTO>();
            var data = userRepository.ReadAll();
            Users = data.Data.ToList();
        }
    }
}
