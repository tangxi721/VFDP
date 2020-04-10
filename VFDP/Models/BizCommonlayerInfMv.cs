using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizCommonlayerInfMv
    {
        public string FacId { get; set; }
        public string CommonCd { get; set; }
        public string CatgCd { get; set; }
        public string CtnDesc { get; set; }
        public string TypVal { get; set; }
        public string ConstVal { get; set; }
        public decimal? InqSeq { get; set; }
        public DateTime CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
