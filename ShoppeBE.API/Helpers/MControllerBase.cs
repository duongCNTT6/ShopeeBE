using Microsoft.AspNetCore.Mvc;
using ShopeeBE.Common.MException;
using ShopeeBE.Common.Models.DTO;
using ShopeeBE.Common.Resources;

namespace ShopeeBE.API.Helpers
{
    public class MControllerBase : ControllerBase
    {
        public IActionResult ExpErrorResponse(MExceptionResponse ex, dynamic? traceId = null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,new ServiceResult(StatusCodes.Status500InternalServerError,ex.Message, ResourceVN.MsgErrorServer, traceId));
        }
    }
}
