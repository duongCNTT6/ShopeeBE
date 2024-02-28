using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeBE.Common.Models.DTO
{
    public class ModelBase
    {
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
