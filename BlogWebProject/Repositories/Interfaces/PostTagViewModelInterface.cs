using BlogProject.Repositories;
using BlogWebProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebProject.Repositories.Interfaces
{
   public interface PostTagViewModelInterface :IRepositoryBase<PostTagsViewModel>
    {
        IEnumerable<PostTagsViewModel> GetPostsForView(string titleSearch=null, string tag=null);
        PostTagsViewModel GetFullPost(int id);
    }
}
