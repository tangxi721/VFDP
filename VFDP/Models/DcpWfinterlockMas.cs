using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpWfinterlockMas
    {
        public string EqpId { get; set; }
        public decimal? HoldCnt { get; set; }
        public decimal? ReleaseCnt { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
