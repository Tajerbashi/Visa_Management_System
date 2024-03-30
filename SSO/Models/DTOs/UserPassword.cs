namespace SSO.Models.DTOs
{
    public class UserPassword
    {
        public UserPassword
            (
        string adminEmail,
        string adminPas,
        string userMail,
        string mailSubject,
        string mailBody
        )
        {
            this.AdminEmail = adminEmail;
            this.AdminPassword = adminPas;
            this.UserMail = userMail;
            this.Subject = mailSubject;
            this.Body = mailBody;
        }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}
