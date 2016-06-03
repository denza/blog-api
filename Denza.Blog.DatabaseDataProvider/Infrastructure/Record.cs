using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Denza.Blog.DatabaseDataProvider.Infrastructure
{
    public class Record<T> where T : new()
    {
        #region Properties

        public static NovoVrijemeDB Repo
        {
            get
            {
                return NovoVrijemeDB.GetInstance();
            }
        }

        #endregion

        #region Methods

        public bool IsNew()
        {
            return Repo.IsNew(this);
        }
        public object Insert() { return Repo.Insert(this); }

        public void Save()
        {
            Repo.Save(this);
        }
        public int Update() { return Repo.Update(this); }

        public int Update(IEnumerable<string> columns)
        {
            return Repo.Update(this, columns);
        }
        public static int Update(string sql, params object[] args)
        {
            return Repo.Update<T>(sql, args);
        }
        public static int Update(Sql sql)
        {
            return Repo.Update<T>(sql);
        }
        public int Delete()
        {
            return Repo.Delete(this);
        }
        public static int Delete(string sql, params object[] args)
        {
            return Repo.Delete<T>(sql, args);
        }
        public static int Delete(Sql sql)
        {
            return Repo.Delete<T>(sql);
        }
        public static int Delete(object primaryKey)
        {
            return Repo.Delete<T>(primaryKey);
        }
        public static bool Exists(object primaryKey)
        {
            return Repo.Exists<T>(primaryKey);
        }
        public static bool Exists(string sql, params object[] args)
        {
            return Repo.Exists<T>(sql, args);
        }
        public static T SingleOrDefault(object primaryKey)
        {
            return Repo.SingleOrDefault<T>(primaryKey);
        }
        public static T SingleOrDefault(string sql, params object[] args)
        {
            return Repo.SingleOrDefault<T>(sql, args);
        }
        public static T SingleOrDefault(Sql sql)
        {
            return Repo.SingleOrDefault<T>(sql);
        }
        public static T FirstOrDefault(string sql, params object[] args)
        {
            return Repo.FirstOrDefault<T>(sql, args);
        }
        public static T FirstOrDefault(Sql sql)
        {
            return Repo.FirstOrDefault<T>(sql);
        }
        public static T Single(object primaryKey)
        {
            return Repo.Single<T>(primaryKey);
        }
        public static T Single(string sql, params object[] args)
        {
            return Repo.Single<T>(sql, args);
        }
        public static T Single(Sql sql)
        {
            return Repo.Single<T>(sql);
        }
        public static T First(string sql, params object[] args)
        {
            return Repo.First<T>(sql, args);
        }
        public static T First(Sql sql)
        {
            return Repo.First<T>(sql);
        }
        public static List<T> Fetch(string sql, params object[] args)
        {
            return Repo.Fetch<T>(sql, args);
        }
        public static List<T> Fetch(Sql sql)
        {
            return Repo.Fetch<T>(sql);
        }
        public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args)
        {
            return Repo.Fetch<T>(page, itemsPerPage, sql, args);
        }
        public static List<T> Fetch(long page, long itemsPerPage, Sql sql)
        {
            return Repo.Fetch<T>(page, itemsPerPage, sql);
        }
        public static List<T> SkipTake(long skip, long take, string sql, params object[] args)
        {
            return Repo.SkipTake<T>(skip, take, sql, args);
        }
        public static List<T> SkipTake(long skip, long take, Sql sql)
        {
            return Repo.SkipTake<T>(skip, take, sql);
        }
        public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args)
        {
            return Repo.Page<T>(page, itemsPerPage, sql, args);
        }
        public static Page<T> Page(long page, long itemsPerPage, Sql sql)
        {
            return Repo.Page<T>(page, itemsPerPage, sql);
        }
        public static IEnumerable<T> Query(string sql, params object[] args)
        {
            return Repo.Query<T>(sql, args);
        }
        public static IEnumerable<T> Query(Sql sql)
        {
            return Repo.Query<T>(sql);
        }

        #endregion
    }
}
