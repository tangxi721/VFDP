using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpElapsedHis
    {
        public decimal DcolDataId { get; set; }
        public decimal TraceSeq { get; set; }
        public decimal? IntvalTm { get; set; }
        public string MethodNm { get; set; }
        public string TraceDesc { get; set; }
    }
}
