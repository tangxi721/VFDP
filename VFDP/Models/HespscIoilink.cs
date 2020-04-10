using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class HespscIoilink
    {
        public string FacNm { get; set; }
        public string DcspecNm { get; set; }
        public string DcspecDesc { get; set; }
        public string ItemNm { get; set; }
        public string ItemDesc { get; set; }
        public decimal? ItemSeq { get; set; }
        public decimal? SiteCnt { get; set; }
        public decimal? SampCnt { get; set; }
        public string SpcruleChk { get; set; }
        public string Ioiactionflag { get; set; }
        public DateTime? CrtTm { get; set; }
        public decimal? CrtSeq { get; set; }
        public string Lock { get; set; }
    }
}
