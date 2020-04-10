using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolformulaitemHis
    {
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string FormulaNm { get; set; }
        public string FormulaCharVal { get; set; }
        public string Timekey { get; set; }
        public DateTime? EventTm { get; set; }
        public string EventCd { get; set; }
        public string EventUserId { get; set; }
        public string EventDesc { get; set; }
        public string FormulaTyp { get; set; }
        public string NoFormulaCd { get; set; }
        public string CaloperCd { get; set; }
        public string PointVal { get; set; }
        public string PreProdId { get; set; }
        public string PreFlowId { get; set; }
        public string PreOperId { get; set; }
        public string CountifMax { get; set; }
        public string CountifMin { get; set; }
        public string RearrangePoint { get; set; }
        public string CalcYn { get; set; }
    }
}
