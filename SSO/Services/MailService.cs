using SSO.BaseSSO.Model;
using SSO.Common;
using SSO.Models.DTOs;
using SSO.Repositpries;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SSO.Services
{
    public class MailService : IMailRepository
    {
        public async Task<Result<bool>> SendGmail(UserPassword config)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 1000000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(config.AdminEmail, config.AdminPassword);

            MailMessage mailMessage = new MailMessage(config.AdminEmail,config.UserMail,config.Subject,config.Body);
            mailMessage.IsBodyHtml = true;
            mailMessage.BodyEncoding = UTF8Encoding.UTF8;
            mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            client.Send(mailMessage);
            await Task.CompletedTask;
            return new Result<bool>
            {
                Data = true,
                Messages = ResponseMessage.Success(),
                Success = true
            };
        }

        public Task<Result<bool>> SendEmail(UserPassword user)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> SendSms(UserPassword user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
