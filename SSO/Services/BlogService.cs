using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Common;
using SSO.DatabaseApplication;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Services
{
    public class BlogService : BaseServices<BlogDTO>, IBlogRepository
    {
        private readonly IAuthorizationService authorizationService;
        public BlogService(DbContextApplication context, IMapper mapper, IAuthorizationService authorizationService) : base(context, mapper)
        {
            this.authorizationService = authorizationService;
        }

        public override Result<long, bool> Create(BlogDTO entity)
        {

            var result = authorizationService.AuthorizeAsync(entity.CurrentUser,entity,"SelfAccessUser");
            return new Result<long, bool> {  };
        }

        public override Result<bool, bool> Delete(BlogDTO entity)
        {
            throw new NotImplementedException();
        }

        public override Result<bool, bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public override Result<bool> Exist(long ID)
        {
            throw new NotImplementedException();
        }

        public override Result<BlogDTO, bool> Read(long Id)
        {
            throw new NotImplementedException();
        }

        public override Result<List<BlogDTO>, bool> ReadAll()
        {
            return new Result<List<BlogDTO>, bool>
            {
                Data = Mapper.Map<List<BlogDTO>>(Context.Blogs.ToList()),
                Messages = ResponseMessage.Success(),
                Success = true,
                Results = true,
            };
        }

        public override Result<bool, bool> Update(BlogDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
