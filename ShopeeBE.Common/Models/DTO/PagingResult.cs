using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.Common.Models.DTO
{
    public class PagingResult<T>
    {
        /// <summary>
        /// Tổng số bản ghi filter
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// Dữ liệu list
        /// </summary>
        public List<T> Data { get; set; }
    }
}
