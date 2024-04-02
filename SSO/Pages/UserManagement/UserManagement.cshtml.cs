using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.UserManagement
{
    public class UserManagementModel : PageModel
    {
        public bool ReadOnly { get; set; }
        [BindProperty]
        public long Id { get; set; }
        public string Mode { get; set; }
        private readonly IUserRepository userRepository;
        [BindProperty]
        public UserDTO UserModel { get; set; }

        [BindProperty]
        public SignUpDTO SignUpModel { get; set; }
        public UserManagementModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }



        public void OnGet(long id)
        {
            Id = id;
            Mode = "صفحه اولیه";
        }
        #region Create
        public void OnGetCreate()
        {
            Id = 0;
            Mode = "ایجاد کردن";
        }
        public IActionResult OnPostCreate()
        {
            if (!ModelState.IsValid)
                return Page();
            var model = new UserDTO
            {
                Name = SignUpModel.Name,
                Family = SignUpModel.Family,
                Email = SignUpModel.Email,
                UserName = SignUpModel.UserName,
                Password = SignUpModel.Password,
            };
            if (SignUpModel.Id == 0)
            {
                var result = userRepository.Create(model);
                if (result.Success)
                {
                    return RedirectToPage("UserPage");
                }
            }
            else
            {
                OnPostUpdate();
            }

            return Page();
        }
        #endregion

        #region Read
        public void OnGetRead(long id)
        {
            Id = id;
            Mode = "خواندن";
            ReadOnly = true;
            var model = userRepository.Read(id);
            UserModel = model.Data;
        }
        #endregion


        #region Update
        public void OnGetUpdate(long id)
        {
            Id = id;
            var model = userRepository.Read(id);
            SignUpModel = new SignUpDTO
            {
                Id = id,
                Name = model.Data.Name,
                Family = model.Data.Family,
                Email = model.Data.Email,
                UserName = model.Data.UserName,
                Password = model.Data.Password,

            };
            Mode = "ویرایش کردن";
        }
        public IActionResult OnPostUpdate()
        {
            var model = new UserDTO
            {
                Id = Id,
                Name = SignUpModel.Name,
                Family = SignUpModel.Family,
                Email = SignUpModel.Email,
                UserName = SignUpModel.UserName,
                Password = SignUpModel.Password,
            };
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var result = userRepository.Update(model);
            if (result.Success)
            {
                return RedirectToPage("UserPage");
            }
            return Page();
        }
        #endregion


        #region Delete
        public IActionResult OnGetDelete(long id)
        {
            Id = id;
            var result =  userRepository.Delete(id);
            return RedirectToPage("UserPage");
        }
        #endregion

        #region Login
        public async Task<IActionResult> OnGetLogin(long id)
        {
            var user = userRepository.Read(id).Data;

            var login = new LoginDTO
            {
                UserName = user.UserName,
                Password = user.Password,
            };

            var res = await userRepository.LoginInternal(login);
            if (res.Success)
                return RedirectToPage("Index");
            else
                return Page();
        }
        #endregion

        public IActionResult OnGetRolesOfUser(string Id)
        {
            return Redirect("RolesOfUserPage");
        }
    }
}
