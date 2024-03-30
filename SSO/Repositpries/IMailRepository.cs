using SSO.BaseSSO.Model;
using SSO.Models.DTOs;

namespace SSO.Repositpries
{
    public interface IMailRepository : IDisposable
    {
        Task<Result<bool>> SendGmail(UserPassword user);
        Task<Result<bool>> SendEmail(UserPassword user);
        Task<Result<bool>> SendSms(UserPassword user);
    }

    
}
