using Dapper;
using MySqlConnector;
using ShopeeBE.DL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.DL.Database
{
    public class DatabaseConnection : IDatabaseConnection
    {
        private MySqlConnection? _connection;
        private MySqlTransaction? _transaction;

        public void Close()
        {
            if (_connection != null)
            {
                _connection.Clone();
                _connection.Dispose();
            }
        }

        public int Execute(string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            _connection = new MySqlConnection(DatabaseContext.ConnectionString);
            _connection.Open();
        }

        public T QueryFirstOrDefault<T>(string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            throw new NotImplementedException();
        }

        public object QueryFirstOrDefault(string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            throw new NotImplementedException();
        }

        public SqlMapper.GridReader QueryMultiple(string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return QueryMultiple(sql, param, transaction, commandTimeout, commandType);
        }

        public void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
            }
        }
        public void BeginTransaction()
        {
            if(_connection != null)
            {
                this._transaction = this._connection.BeginTransaction();
            }
        }
        public MySqlTransaction? Transaction()
        {
            return _transaction;
        }

        public void CommitTransaction()
        {
            if(_transaction != null)
            {
                this._transaction.Commit();
            }
        }
    }
}
