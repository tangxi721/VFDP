using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpRecoveryprocMas
    {
        public string FacId { get; set; }
        public string MsgCmd { get; set; }
        public string MsgProcTyp { get; set; }
        public string MsgFormat { get; set; }
        public string ClassPath { get; set; }
        public decimal? GrpId { get; set; }
        public string SendNode { get; set; }
        public string SendProc { get; set; }
        public string ListenProc { get; set; }
        public string SubjCmd { get; set; }
        public string SendTyp { get; set; }
        public decimal? TimeoutSec { get; set; }
        public string CrtUser { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUser { get; set; }
        public DateTime? ChgTm { get; set; }
    }
}
