using BlogWebProject.Data;
using BlogWebProject.Models;
using BlogWebProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebProject.Repositories.Implementation
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

    }
}
