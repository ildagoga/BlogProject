using BlogWebProject.Data;
using BlogWebProject.Models;
using BlogWebProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebProject.Repositories.Implementation
{
    public class TagsRepository : RepositoryBase<Tag>, ITagsRepository
    {
        public TagsRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
