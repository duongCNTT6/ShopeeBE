using ShopeeBE.BL.Interfaces;
using ShopeeBE.Common.Models.DTO;
using ShopeeBE.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.BL.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        private IBaseDL<T> _baseDL;
        public BaseService(IBaseDL<T> baseDL)
        {
            _baseDL = baseDL;
        }
        public bool DeleteRecords(List<Guid> listId)
        {
            throw new NotImplementedException();
        }

        public PagingResult<T> GetByFilter(dynamic parameters)
        {
            return _baseDL.GetByFilter(parameters);
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
