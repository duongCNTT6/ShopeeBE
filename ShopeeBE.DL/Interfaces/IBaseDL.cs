using ShopeeBE.Common.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.DL.Interfaces
{
    public interface IBaseDL<T>
    {
        /// <summary>
        /// Lấy danh sách có bộ lọc
        /// </summary>
        /// <param name="parameters">Param bộ lọc truyền vào truyền vào</param>
        /// <returns>Danh sách đối tượng</returns>
        public PagingResult<T> GetByFilter(dynamic parameters);

        /// <summary>
        /// Lấy dữ liệu theo ID
        /// </summary>
        /// <param name="id">Id đối tượng</param>
        /// <returns>Đối tượng</returns>
        public T GetById(Guid id);

        /// <summary>
        /// Thêm 1 bản ghi
        /// </summary>
        /// <param name="entity">Đối tượng thêm</param>
        /// <returns>0 : thất bại - 1 : thành công</returns>
        public bool Insert(T entity);
        /// <summary>
        /// Sửa 1 bản ghi
        /// </summary>
        /// <param name="entity">Đối tượng update</param>
        /// <returns>0 : thất bại - 1 : thành công</returns>
        public bool Update(T entity);

        /// <summary>
        /// Xóa nhiều bản ghi
        /// </summary>
        /// <param name="listId">ListID</param>
        /// <returns>Số bản ghi thay đổi</returns>
        public bool DeleteRecords(List<Guid> listId);
    }
}
