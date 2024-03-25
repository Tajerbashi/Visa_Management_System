using Microsoft.AspNetCore.Identity;

namespace SSO.Common
{
    public static class ResponseMessage
    {
        public static string Success() => "عملیات با موفقیت انجام شد";
        public static string Faild() => "عملیات انجام نشده است";
        public static string Exist() => "اطلاعات تکرار است";
        public static string EmptyModel() => "مدل خالی است";
        public static string InValidMadel() => "مدل نامعتبر است";
        public static string MessageeLine(List<string> message)
        {
            var result  = "";
            foreach (var item in message)
            {
                result += item + Environment.NewLine;
            }
            return result;
        }

        public static object MessageeLine(IEnumerable<IdentityError> errors)
        {
            var result  = "";
            foreach (var item in errors.ToList())
            {
                result += item.Description + Environment.NewLine;
            }
            return result;
        }
    }
}
