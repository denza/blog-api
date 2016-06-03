using Denza.Blog.Api.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Denza.Blog.Rest.Controllers
{
    /// <summary>
    /// Categories
    /// </summary>
    public class CategoriesController : ApiController
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

        public CategoriesController()
        {
            _api = Infrastructure.ServiceLocator.Instance.Resolve<IBlogApi>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get All categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IQueryable<Denza.Blog.Api.Public.Entities.Category> GetCategories()
        {
            //return _api.GetCategories();
            throw new NotImplementedException();
        }

        #endregion
    }
}
