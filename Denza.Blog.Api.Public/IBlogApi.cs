using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denza.Blog.Api.Public.Entities;

namespace Denza.Blog.Api.Public
{
    public interface IBlogApi
    {
        #region Popular

        IQueryable<Category> GetPopularCategories(int? categoryNumber,int? postNumber);

        #endregion

        #region Categories

        IQueryable<Category> GetCategories(int? page, int? size);

        Category GetCategoryByName(string name);

        #endregion

        #region Posts

        Post GetPostById(int postId);

        IQueryable<Post> GetPostByAuthor(string author);

        IQueryable<Post> GetPostsByCategory(string name, int? page, int? size);

        #endregion

        #region Comments

        IQueryable<Comment> GetPostComment(int postId);

        #endregion




    }
}
