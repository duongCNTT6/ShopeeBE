using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.Common.Models.DTO
{
    /// <summary>
    /// class trả về dữ liệu 
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        /// Mã lỗi
        /// </summary>
        public int errorCode { get; set; }
        /// <summary>
        /// Message cho develop
        /// </summary>
        public string devMsg { get; set; }
        /// <summary>
        /// Message cho người dùng
        /// </summary>
        public string userMsg { get; set; }
        /// <summary>
        /// Thông tin chi tiết lỗi
        /// </summary>
        public object moreInfo { get; set; }
        /// <summary>
        /// Id lỗi exception
        /// </summary>
        public dynamic? traceId { get; set; }
        public ServiceResult(){}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorCode">Mã lỗi</param>
        /// <param name="devMsg">Msg dev</param>
        /// <param name="userMsg">Msg người dùng</param>
        /// <param name="moreInfo">Chi tiết lỗi</param>
        /// <param name="traceId">ID exp lỗi</param>
        public ServiceResult(int errorCode,string devMsg,string userMsg,object moreInfo,dynamic? traceId = null)
        {
            this.errorCode = errorCode;
            this.devMsg = devMsg;
            this.userMsg = userMsg;
            this.moreInfo = moreInfo;
            this.traceId= traceId;
        }
    }
}
