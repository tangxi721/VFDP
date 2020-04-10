using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpMvouSyncRaw
    {
        public string Fab { get; set; }
        public string EqpId { get; set; }
        public string Tid { get; set; }
        public decimal Trycount { get; set; }
        public string Msg { get; set; }
    }
}
