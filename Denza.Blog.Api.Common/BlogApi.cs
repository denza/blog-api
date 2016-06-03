using Denza.Blog.Api.Public;
using Denza.Blog.Api.Public.Entities;
using Denza.Blog.Api.Public.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denza.Blog.Api.Common
{
    public class BlogApi : IBlogApi
    {
        #region Fields

        IBlogApiDataProvider _dataProvider;

        #endregion

        #region Properties

        public IBlogApiDataProvider DataProvider
        {
            get
            {
                return _dataProvider;
            }
        }

        #endregion

        #region Constructor

        public BlogApi(IBlogApiDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        #endregion

        #region Methods

        public Post GetPostById(int postId)
        {
            return _dataProvider.GetPostById(postId);
        }

        [Obsolete]
        //public IQueryable<Post> GetPostByName(string name)
        //{
        //    return _dataProvider.GetPostByName(name);
        //}

        public IQueryable<Post> GetPostByAuthor(string author)
        {
            return _dataProvider.GetPostByAuthor(author);
        }

        public IQueryable<Category> GetPopularCategories(int? categoryNumber, int? postNumber)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetCategories(int? page, int? size)
        {
            if (page.HasValue && size.HasValue)
            {
                return _dataProvider.GetCategories(page.Value, size.Value);
            }

            return _dataProvider.GetCategories(null,null);
        }

        public Category GetCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post> GetPostsByCategory(string name, int? page, int? size)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> GetPostComment(int postId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
