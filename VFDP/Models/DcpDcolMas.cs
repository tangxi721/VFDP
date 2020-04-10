using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolMas
    {
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string CtnDesc { get; set; }
        public string ChkStatCd { get; set; }
        public string ActiveStatCd { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChkoutTm { get; set; }
        public string ChkoutUserId { get; set; }
        public string MatlTyp { get; set; }
        public string SampMatlTyp { get; set; }
        public decimal? SampCnt { get; set; }
        public string DcolTyp { get; set; }
        public string AutoChgYn { get; set; }
        public string AutoParaChgYn { get; set; }
    }
}
