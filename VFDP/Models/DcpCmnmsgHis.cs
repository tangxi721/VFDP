using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpCmnmsgHis
    {
        public decimal DcolDataId { get; set; }
        public string FacId { get; set; }
        public string EventCd { get; set; }
        public string LotId { get; set; }
        public string EqpId { get; set; }
        public string Timekey { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ResvFieldVal1 { get; set; }
        public string ResvFieldVal2 { get; set; }
        public string ResvFieldVal3 { get; set; }
        public string ResvFieldVal4 { get; set; }
        public string ResvFieldVal5 { get; set; }
        public string ResvFieldVal6 { get; set; }
        public string ResvFieldVal7 { get; set; }
        public string ResvFieldVal8 { get; set; }
        public string ResvFieldVal9 { get; set; }
        public string ResvFieldVal10 { get; set; }
        public string MainEqpId { get; set; }
        public string MainFlowId { get; set; }
        public string MainOperId { get; set; }
        public string MainEventTm { get; set; }
        public string XmlMsg { get; set; }
    }
}
