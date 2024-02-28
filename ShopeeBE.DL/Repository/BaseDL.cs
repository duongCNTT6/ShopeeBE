using Dapper;
using ShopeeBE.Common.MException;
using ShopeeBE.Common.Models.DTO;
using ShopeeBE.DL.Database;
using ShopeeBE.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.DL.Repository
{
    public class BaseDL<T> : IBaseDL<T>
    {
        private string tableName;
        private IDatabaseConnection _databaseConnection;
        public BaseDL(IDatabaseConnection databaseConnection)
        {
            tableName = typeof(T).Name;
            _databaseConnection = databaseConnection;
        }
        public bool DeleteRecords(List<Guid> listId)
        {
            throw new NotImplementedException();
        }

        public PagingResult<T> GetByFilter(dynamic parameters)
        {
            try
            {
                var result = new PagingResult<T>();
                // Tên store
                string storeName = $"Proc_{tableName}_GetByFilter";
                // Tham số đầu vào
                var param = new DynamicParameters();
                param.Add("@TotalRecords", direction: ParameterDirection.Output);
                foreach (PropertyInfo propertyInfo  in parameters.GetType().GetProperties())
                {
                    param.Add("p_"+ propertyInfo.Name, propertyInfo.GetValue(parameters));
                }
                _databaseConnection.Open();
                var res = _databaseConnection.QueryMultiple(storeName, param,null,null,CommandType.StoredProcedure);
                _databaseConnection.Close();

                result.Data = res.Read<T>().ToList();
                result.Total = param.Get<int>("@TotalRecords");

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _databaseConnection.Close();
                throw new MExceptionResponse(ex.Message);
            }
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
