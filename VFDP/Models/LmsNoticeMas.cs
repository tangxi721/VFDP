using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsNoticeMas
    {
        public decimal NoticeId { get; set; }
        public string AreaId { get; set; }
        public string EqpId { get; set; }
        public string Contents { get; set; }
        public string FromTm { get; set; }
        public string ToTm { get; set; }
        public string UserId { get; set; }
        public DateTime CrtTm { get; set; }
    }
}
