using BlogWebProject.Data;
using BlogWebProject.Models;
using BlogWebProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebProject.Repositories.Implementation
{
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}