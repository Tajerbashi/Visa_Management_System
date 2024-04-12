using Microsoft.AspNetCore.Identity;

namespace Blazor_Application_Library.Helpers
{
    public static class ApplicationMessages
    {
        public static string Success() => $"عملیات با موفقیت انجام شد";
        public static string Faild() => $"عملیات ناموفق بود";
        public static string WrongRequest() => $"درخواست اشتباه است";
        public static string NotValidData() => $"اطلاعات نامعتبر است";
        public static string ValidData() => $"اطلاعات معتبر است";
        public static string NotFoundData() => $"اطلاعات موجود نیست";
        public static string NotAccess() => $"دسترسی ندرید";
        public static string CallSupport() => $"با پشتیبانی تماس بگیرید";
        public static string FaildLogin() => "عملیات ورود ناموفق بود";
        public static string WrongPassword() => "رمز اشتباه است";

        public static string MessageeLine(List<string> message)
        {
            var result  = "";
            foreach (var item in message)
            {
                result += item + Environment.NewLine;
            }
            return result;
        }

        public static object IdentityErrors(IEnumerable<IdentityError> errors)
        {
            var result  = "";
            foreach (var item in errors.ToList())
            {
                result += $"{item.Code} : {item.Description + Environment.NewLine} \n \n";
            }
            return result;
        }
    }
}
