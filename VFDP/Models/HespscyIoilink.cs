using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class HespscyIoilink
    {
        public string Fab { get; set; }
        public string ParasetId { get; set; }
        public string ParaId { get; set; }
        public decimal? ParaSeq { get; set; }
        public string DrivenFlag { get; set; }
        public string Tgt { get; set; }
        public string Usl { get; set; }
        public string Lsl { get; set; }
        public string Ucl1 { get; set; }
        public string Lcl1 { get; set; }
        public string Ucl2 { get; set; }
        public string Lcl2 { get; set; }
        public string Ucl3 { get; set; }
        public string Lcl3 { get; set; }
        public string Ucl4 { get; set; }
        public string Lcl4 { get; set; }
        public string Ucl5 { get; set; }
        public string Lcl5 { get; set; }
        public string IoiactionFlag { get; set; }
        public DateTime? CrtTm { get; set; }
        public decimal CrtSeq { get; set; }
        public string Lock { get; set; }
    }
}
