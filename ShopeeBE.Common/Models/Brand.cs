using ShopeeBE.Common.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.Common.Models
{
    public class Brand : ModelBase
    {
        public Guid BrandId { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public string? Description { get; set; }
        public Brand()
        {

        }
        public Brand(Guid brandId, string brandName)
        {
            this.BrandId = brandId;
            this.BrandName = brandName;
        }
        public Brand(Guid brandId, string brandName, string? description, DateTime createdAt, DateTime modifiedAt, bool isActive, bool isDelete) : this(brandId, brandName)
        {
            Description = description;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            IsActive = isActive;
            IsDelete = isDelete;
        }
    }
}
