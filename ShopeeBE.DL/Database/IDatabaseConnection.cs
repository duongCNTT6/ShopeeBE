using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace ShopeeBE.DL.Database
{
    public interface IDatabaseConnection
    {
        /// <summary>
        /// Mở kết nối
        /// </summary>
        void Open();
        /// <summary>
        /// Đóng kết nối
        /// </summary>
        void Close();
        /// <summary>
        /// trả về transaction
        /// </summary>
        MySqlTransaction? Transaction();
        /// <summary>
        /// Khởi tạo transaction
        /// </summary>
        void BeginTransaction();

        void CommitTransaction();
        /// <summary>
        /// Hủy bỏ transaction
        /// </summary>
        void RollbackTransaction();

        /// <summary>
        /// Hàm gọi vào db trả ra số bản ghi được xử lý thành công
        /// </summary>
        /// <param name="sql">Cây lệnh sql hoặc tên store (Dựa vào commandType)</param>
        /// <param name="param">Tham số đầu vào</param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType">Loại truy vấn (câu lệnh hoặc gọi store)</param>
        /// <returns></returns>
        public int Execute(string sql, object? param = null, IDbTransaction? transaction = null,int? commandTimeout = null,CommandType? commandType = null);
        /// <summary>
        /// Hàm trả về 1 object (class) mình mong muốn
        /// </summary>
        /// <param name="sql">Cây lệnh sql hoặc tên store (Dựa vào commandType)</param>
        /// <param name="param">Tham số đầu vào</param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType">Loại truy vấn (câu lệnh hoặc gọi store)</param>
        /// <returns></returns>
        public T QueryFirstOrDefault<T>(string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        /// <summary>
        /// Hàm trả về 1 object (class) mình mong muốn
        /// </summary>
        /// <param name="sql">Cây lệnh sql hoặc tên store (Dựa vào commandType)</param>
        /// <param name="param">Tham số đầu vào</param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType">Loại truy vấn (câu lệnh hoặc gọi store)</param>
        /// <returns></returns>
        public object QueryFirstOrDefault(string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// Hàm trả về dạng nhiều object 
        /// </summary>
        /// <param name="sql">Cây lệnh sql hoặc tên store (Dựa vào commandType)</param>
        /// <param name="param">Tham số đầu vào</param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType">Loại truy vấn (câu lệnh hoặc gọi store)</param>
        /// <returns></returns>
        public GridReader QueryMultiple(string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null);
    }
}
