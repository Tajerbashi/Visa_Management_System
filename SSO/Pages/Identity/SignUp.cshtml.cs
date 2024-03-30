using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;
using SSO.Services;

namespace SSO.Pages.Identity
{
    public class SignUpModel : PageModel
    {
        private readonly IUserRepository userRepository;
        private readonly IMailRepository mailRepository;

        public SignUpModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
            this.mailRepository = new MailService();
        }

        public IActionResult OnGet()
        {

            return Page();

        }

        [BindProperty]
        public SignUpDTO SignUpDTO { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await Task.Delay(100);
            var entity = new UserDTO
            {
                Name = SignUpDTO.Name,
                Family = SignUpDTO.Family,
                Email = SignUpDTO.Email,
                UserName = SignUpDTO.UserName,
                Password = SignUpDTO.Password,
                IsDeleted = false,
                IsActive= true
            };
            var res = userRepository.Create(entity);
            if (res.Success)
            {
                var token = userRepository.GeneratToken(res.Data);
                //var  callBackLink = Url.Action("ConfimEmail","Account",new
                //{
                //    UserId=res.Data,
                //    token=token
                //},protocol:Request.Scheme);

                var callBackLink = Url.PageLink("ConfirmAccount");
                string body = $@"
برای فعال سازی حساب کاربری خو روی 
<a href={callBackLink}>لینک</a>
کلیک کنید
";
                var config= new UserPassword
                (
                  "",//AdminEmail
                  "",//AdminPass
                  "",//UserEmail
                  "",//Subject
                  ""//Body
                );

                var mail = await mailRepository.SendGmail(config);
                return RedirectToPage("./DisplayEmail");
            }
            ViewData["Messages"] = res.Messages;
            return Page();
        }
    }
}
