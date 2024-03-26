using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserRepository userRepository;
        public IndexModel(ILogger<IndexModel> logger, IUserRepository userRepository)
        {
            _logger = logger;
            this.userRepository = userRepository;
        }
        [BindProperty]
        public List<UserDTO> Users { get; set; }
        public void OnGet()
        {
            Users = userRepository.ReadAll().Data;
            ViewData["ActiveUsers"] = Users.Count;
        }
        
    }
}
