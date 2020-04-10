using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolformulabaseInf
    {
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string FormulaNm { get; set; }
        public string CalcFormulaCtn { get; set; }
        public string ApplyYn { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
    }
}
