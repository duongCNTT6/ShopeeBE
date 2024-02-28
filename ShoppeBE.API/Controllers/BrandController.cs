using Microsoft.AspNetCore.Mvc;
using ShopeeBE.BL.Interfaces;
using ShopeeBE.Common.Models;
using ShoppeBE.API.Controllers;

namespace ShopeeBE.API.Controllers
{
    public class BrandController : BaseController<Brand>
    {
        private IBaseService<Brand> _baseService;
        //public BrandController(IBaseService<Brand> baseService, IHttpContextAccessor httpContextAccessor, IUserTokenService userTokenService) : base(baseService, httpContextAccessor, userTokenService)
        //{
        //    _baseService = baseService;
        //}
        public BrandController(IBaseService<Brand> baseService):base(baseService)
        {
            _baseService = baseService;
        }
    }
}
