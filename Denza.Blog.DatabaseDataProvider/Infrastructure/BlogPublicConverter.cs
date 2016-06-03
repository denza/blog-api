using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denza.Blog.Api.Public.Entities;

namespace Denza.Blog.DatabaseDataProvider.Infrastructure
{
    public static class BlogPublicConverter
    {
        public static Post ToPublic(this Denza.Blog.DatabaseDataProvider.Models.Post record)
        {
            //TODO
            return new Post()
                       {
                           PostId = record.ID,
                           Title = record.Title,
                           Author = record.Author,
                           DateGmt = record.DateGmt,
                           Content = record.Content
                       };
        }

        public static Category ToPublic(this Denza.Blog.DatabaseDataProvider.Models.Category record)
        {
            return new Category()
                       {
                           CategoryId = record.CategoryId,
                           Name = record.Name
                       };
        }

    }
}
