using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpMdptimekeyMas
    {
        public string DataTyp { get; set; }
        public string FacId { get; set; }
        public string Timekey { get; set; }
        public string DcolDataId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string CancelTimekey { get; set; }
        public string MsgId { get; set; }
        public string ResvFieldVal1 { get; set; }
        public string ResvFieldVal2 { get; set; }
        public string ResvFieldVal3 { get; set; }
        public string ResvFieldVal4 { get; set; }
        public string ResvFieldVal5 { get; set; }
        public string ResvTimekey { get; set; }
    }
}
