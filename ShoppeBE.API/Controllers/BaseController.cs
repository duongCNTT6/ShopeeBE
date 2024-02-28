using Microsoft.AspNetCore.Mvc;
using ShopeeBE.API.Helpers;
using ShopeeBE.BL.Interfaces;
using ShopeeBE.Common.MException;
using ShopeeBE.Common.Models.DTO;

namespace ShoppeBE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T> : MControllerBase
    {
        private IBaseService<T> _baseService { get; set; }
        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }
        [HttpPost]
        [Route("Filter")]
        public virtual IActionResult GetByFilter([FromBody] PagingModel paramFilter)
        {
            try
            {
                var res = _baseService.GetByFilter(paramFilter);
                return StatusCode(StatusCodes.Status200OK, res);
            }
            catch (MExceptionResponse ex)
            {
                return ExpErrorResponse(ex, ex.StackTrace);
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        public virtual IActionResult GetById(Guid id)
        {
            try
            {
                //// Xử lý lấy dữ liệu
                return StatusCode(500, "");
            }
            catch (MExceptionResponse ex)
            {
                return ExpErrorResponse(ex,ex.StackTrace);
            }
        }
    }
}