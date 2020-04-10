using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsMachineTrx
    {
        public decimal Rawid { get; set; }
        public string EqpId { get; set; }
        public string ChId { get; set; }
        public string StartDtts { get; set; }
        public string EndDtts { get; set; }
        public string StartEvent { get; set; }
        public string EndEvent { get; set; }
        public string EventNm { get; set; }
        public string EventText { get; set; }
        public string EqpStat { get; set; }
        public DateTime CrtDtts { get; set; }
    }
}
