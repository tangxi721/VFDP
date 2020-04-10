using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpRecoveryexecHis
    {
        public DateTime EventTm { get; set; }
        public string MsgCmd { get; set; }
        public string MsgProcTyp { get; set; }
        public string ExecRslt { get; set; }
        public string ExecTyp { get; set; }
        public string MenuId { get; set; }
        public string CrtUserId { get; set; }
        public DateTime CrtTm { get; set; }
    }
}
