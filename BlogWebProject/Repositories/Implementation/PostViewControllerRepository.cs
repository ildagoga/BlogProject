using BlogWebProject.Data;
using BlogWebProject.Repositories.Interfaces;
using BlogWebProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebProject.Repositories.Implementation
{
    public class PostViewControllerRepository : RepositoryBase<PostsViewModel>, IPostViewControllerRepository
    {
        public PostViewControllerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

    }
}
