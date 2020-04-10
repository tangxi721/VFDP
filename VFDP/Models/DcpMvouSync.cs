using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpMvouSync
    {
        public string MsgKey { get; set; }
        public string EqpId { get; set; }
        public string LotId { get; set; }
        public string Fab { get; set; }
        public string SyncYn { get; set; }
        public DateTime? CrtTm { get; set; }
    }
}
