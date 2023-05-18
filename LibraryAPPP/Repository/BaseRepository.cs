using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using LibraryAPPP.Consts;
using Microsoft.Extensions.Configuration;
using LibraryAPPP.Enums;

namespace LibraryAPPP.Repository
{
    public class BaseRepository
    {
        protected readonly IConfiguration _config;
        protected readonly string _connectionString;

        protected virtual RepositoryType RepositoryType => RepositoryType.LibraryDB;

        public BaseRepository(IConfiguration config)
        {
            _config = config;
            _connectionString = config.GetConnectionString(ConnectionStringName);
        }

        protected IEnumerable<T> Select<T>(string selectQuery)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return Select<T>(selectQuery, connection);
            }
        }

        protected IEnumerable<T> Select<T>(string selectQuery, SqlConnection connection)
        {
            return Select<T>(selectQuery, connection, null);
        }

        protected IEnumerable<T> Select<T>(string selectQuery, object parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return Select<T>(selectQuery, connection, parameters);
            }
        }

        protected IEnumerable<T> Select<T>(string selectQuery, SqlConnection connection, object parameters)
        {
            IEnumerable<T> items = connection.Query<T>(selectQuery, parameters);
            return items;
        }

        protected T Get<T>(string getQuery)
        {
            var itemList = Select<T>(getQuery);
            return itemList.FirstOrDefault();
        }

        protected T Get<T>(string getQuery, SqlConnection connection)
        {
            var itemList = Select<T>(getQuery, connection);
            return itemList.FirstOrDefault();
        }

        protected void Insert(string command)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Execute(command);
            }
        }

        protected void Update(string command)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Execute(command);
            }
        }

        protected void Delete(string command)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Execute(command);
            }
        }
        private string ConnectionStringName
        {
            get
            {
                switch (RepositoryType)
                {
                    case RepositoryType.LibraryDB:
                        return ConnectionTypeName.LibraryDB;
                    default:
                        return null;
                }
            }
        }
    }
}
