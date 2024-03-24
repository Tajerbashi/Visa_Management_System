namespace SSO.Common
{
    public static class ResponseMessage
    {
        public static string Success() => "عملیات با موفقیت انجام شد";
        public static string Faild() => "عملیات انجام نشده است";
        public static string Exist() => "اطلاعات تکرار است";
        public static string EmptyModel() => "مدل خالی است";
        public static string InValidMadel() => "مدل نامعتبر است";
    }
}
