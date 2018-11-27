using BlogProject.Repositories.Interfaces;
using BlogWebProject.Data;
using BlogWebProject.Models;
using BlogWebProject.Repositories.Interfaces;
using BlogWebProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebProject.Repositories.Implementation
{
    public class PostPerUserRepository : RepositoryBase<PostsPerUser>, IPostsPerUser
    {
        public PostPerUserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {

    }

        public PostsPerUser FindPostsPerUser(string userId)
        {
            var model = new PostsPerUser
            {
                Posts = ApplicationDbContext.Posts.Where(i => i.UserId == userId),
                UserObj = ApplicationDbContext.Users.FirstOrDefault(user => user.Id == userId)
            };

            return model;
            
        }
    }
}
