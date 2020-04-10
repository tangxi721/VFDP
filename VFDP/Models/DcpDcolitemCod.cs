using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolitemCod
    {
        public string DcolItemCd { get; set; }
        public string CtnDesc { get; set; }
        public string DataTyp { get; set; }
        public string UomCd { get; set; }
        public string ObjItemNm { get; set; }
        public decimal? EfctDigitVal { get; set; }
        public decimal? Idx { get; set; }
        public decimal? MaxUnitVal { get; set; }
        public string CalcUnitVal { get; set; }
        public string CalcFmtTyp { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ItemTyp { get; set; }
        public string RawDataUnitVal { get; set; }
        public string ExcludeVal1 { get; set; }
        public string ExcludeVal2 { get; set; }
        public string ExcludeVal3 { get; set; }
        public string ExcludeVal4 { get; set; }
        public string ExcludeVal5 { get; set; }
    }
}
