using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using System.Configuration;
using Denza.Blog.Api.Public;
using Denza.Blog.Api.Public.Entities;

namespace Denza.Blog.Rest.Controllers
{
    /// <summary>
    /// Posts
    /// </summary>
    public class PostsController : ApiController
    {
        #region Fields

        private readonly IBlogApi _api;

        #endregion

        #region Properties

        protected IBlogApi Api
        {
            get
            {
                return _api;
            }
        }

        #endregion

        #region Constructors

        public PostsController()
        {
            _api = Infrastructure.ServiceLocator.Instance.Resolve<IBlogApi>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets Post by name
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IQueryable<Post> GetPosts()
        {
            //return _api.GetPostByName("panorama");
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets Post by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Post GetPosts(int id)
        {
            return _api.GetPostById(id);
        }

        #endregion
    }
}
