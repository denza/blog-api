using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Denza.Blog.Data.DBManager
{
    public sealed class DapperDBManager
    {
        private static volatile DapperDBManager _instance=null;
        private static object syncRoot = new Object();
        private readonly MySqlConnection _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["NovoVrijeme"].ConnectionString);

        private DapperDBManager()
        {
        }

        public static DapperDBManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new DapperDBManager();
                    }
                }
                return _instance;
            }
        }

        public MySqlConnection GetDbConnection
        {
            get
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        ~DapperDBManager()
        {
            _connection.Close();
        }
    }
}
