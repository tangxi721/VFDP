using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class SystemCode
    {
        public string Category { get; set; }
        public string Code { get; set; }
        public short? DisplayOrder { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UpdateUserId { get; set; }
    }
}
