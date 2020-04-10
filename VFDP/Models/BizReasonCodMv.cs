using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizReasonCodMv
    {
        public string FacId { get; set; }
        public string ReasonCatgCd { get; set; }
        public string ReasonCd { get; set; }
        public string CtnDesc { get; set; }
        public string UpperReasonCd { get; set; }
        public decimal? LevelNo { get; set; }
        public string EnableYn { get; set; }
        public string ObjId { get; set; }
        public string DefaultYn { get; set; }
        public string TrblAlarmYn { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public string ReasonDesc { get; set; }
        public string FutureHoldActCd { get; set; }
        public string AutoRwkTyp { get; set; }
        public string AutoTyp { get; set; }
        public string ActualHoldTyp { get; set; }
        public string MdmIfTyp { get; set; }
        public string HoldTyp { get; set; }
    }
}
