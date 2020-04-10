using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcollimitsepInf
    {
        public string FacId { get; set; }
        public string TechNm { get; set; }
        public string LotCd { get; set; }
        public string OperId { get; set; }
        public string DcolItemCd { get; set; }
        public string SepTyp { get; set; }
        public string LowerSepCode { get; set; }
        public string SeplimitDesc { get; set; }
        public string LowerSetupVal { get; set; }
        public string LowerLimitVal { get; set; }
        public string UpperSetupVal { get; set; }
        public string UpperLimitVal { get; set; }
        public string UpperSepCode { get; set; }
        public string DeleteYn { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
    }
}
