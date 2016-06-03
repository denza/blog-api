using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using MySql;
using MySql.Data;
using System.Configuration;
using Dapper;
using Denza.Blog.Data.DBManager;

namespace Denza.Blog.Data
{
    public class Repository:IRepository
    {
       
        public IEnumerable<wpPost> PetaPocoGetPosts()
        {
            return PetaPocoDbManager.Instance.GetDBConnection.Query<wpPost>("SELECT * FROM wp_posts");
        }

        public IEnumerable<dynamic> DapperGetPosts()
        {
            return DapperDBManager.Instance.GetDbConnection.Query<dynamic>("SELECT * FROM wp_posts");
        }
    }
}
