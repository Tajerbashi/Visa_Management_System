using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Common;
using SSO.Enums;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.Identity
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly IUserRepository _userRepository;

        public ForgotPasswordModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [ModelBinder]
        public SignUpDTO Entity { get; set; }
        [ModelBinder]
        public string Email { get; set; }
        [ModelBinder]
        public string Token { get; set; }

        public ForgotPassPage Type { get; set; }

        public void OnGet()
        {
            Type = ForgotPassPage.ForgotPassSendEmail;
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(Email) && !string.IsNullOrWhiteSpace(Email))
            {
                var result = _userRepository.ReadDataByEmail(Email);
                #region ConfirmEmailBySendLinkToEmail
                #endregion
                if (result.Success)
                {
                    Type = ForgotPassPage.ForgotResetPasss;
                    Entity = result.Data;
                    Token = result.Results;
                    return Page();
                }
                ViewData["Errors"] = ResponseMessage.Faild();
                return Page();
            }
            ViewData["Errors"] = ResponseMessage.InValidMadel();
            return Page();
        }
        public IActionResult OnPostResetPassword()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Entity.Password != Entity.ConfirmPassword)
            {
                return BadRequest();
            }
            var result = _userRepository.ResetPassword(Entity,Token,Entity.Password);
            if (result.Success)
            {
                Type = ForgotPassPage.ForgotResetPassSuccess;
                return Page();
            }
            return Page();
        }
        public IActionResult OnGetRedirectToLogin()
        {
            return RedirectToPage("Login");
        }
    }

}
