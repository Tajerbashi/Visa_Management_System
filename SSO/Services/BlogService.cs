using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Common;
using SSO.DatabaseApplication;
using SSO.Domains;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Services
{
    public class BlogService : BaseServices<BlogDTO>, IBlogRepository
    {
        private readonly IAuthorizationService authorizationService;
        private readonly IUserRepository userRepository;
        public BlogService(DbContextApplication context, IMapper mapper, IAuthorizationService authorizationService, IUserRepository userRepository) : base(context, mapper)
        {
            this.authorizationService = authorizationService;
            this.userRepository = userRepository;
        }

        public override Result<long, bool> Create(BlogDTO entity)
        {
            var User = userRepository.Read(entity.CurrentUser).Data;
            entity.UserId = User.Id;
            var model = Mapper.Map<BlogEntity>(entity);
            model.IsActive = true;
            model.IsDeleted = false;
            Context.Add(model);
            base.SaveChanges();
            return new Result<long, bool>
            {
                Data = entity.UserId,
                Success = true,
                Messages = ResponseMessage.Success(),
                Results = true
            };
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
            return new Result<BlogDTO, bool>
            {
                Results = true,
                Success = true,
                Data = Mapper.Map<BlogDTO>(Context.Blogs.Find(Id)),
                Messages = ResponseMessage.Success()
            };
        }

        public override Result<List<BlogDTO>, bool> ReadAll()
        {
            return new Result<List<BlogDTO>, bool>
            {
                Data = Mapper.Map<List<BlogDTO>>(Context.Blogs.Include(x => x.UserEntity).ToList()),
                Messages = ResponseMessage.Success(),
                Success = true,
                Results = true,
            };
        }

        public override Result<bool, bool> Update(BlogDTO entity)
        {
            var blog = Context.Blogs.Include(x => x.UserEntity).Where(x => x.Id == entity.Id).Select(model => new BlogDTO
            {
                Id = model.Id,
                Body = model.Body,
                Title = model.Title,
                Description = model.Description,
                IsActive = model.IsActive,
                IsDeleted = model.IsDeleted,
                Like = model.Like,
                Share = model.Share,
                User = Mapper.Map<UserDTO>(model.UserEntity),
                UserId = model.UserId,
                UserName = model.UserEntity.UserName
            }) .FirstOrDefault();

            var result = authorizationService.AuthorizeAsync(entity.CurrentUser,blog,"SelfAccessUser").Result;
            if (result.Succeeded)
            {
                var Entity = Mapper.Map<BlogEntity>(entity);
                Entity.IsActive = true;
                Entity.IsDeleted = false;
                Context.Blogs.Update(Entity);
                Context.SaveChanges();
                return new Result<bool, bool>
                {
                    Data = true,
                    Messages = ResponseMessage.Success(),
                    Results = true,
                    Success = true,
                };
            }
            return new Result<bool, bool>
            {
                Data = false,
                Messages = ResponseMessage.NotAccess(),
                Results = false,
                Success = false,
            };
        }
    }
}
