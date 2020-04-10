using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpFilterMas
    {
        public string FabId { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public string RouteId { get; set; }
        public string OperId { get; set; }
        public string DataTyp { get; set; }
        public string FilterVal { get; set; }
        public string CorrectPara { get; set; }
        public string EqpId { get; set; }
        public decimal? Rawid { get; set; }
        public string FilterLlVal { get; set; }
        public string FilterUlVal { get; set; }
        public string WarnLlVal { get; set; }
        public string WarnUlVal { get; set; }
        public string SendYn { get; set; }
        public string MinMaxYn { get; set; }
        public decimal? Offset { get; set; }
        public string UseYn { get; set; }
        public string ApplyYn { get; set; }
        public string CtrlDesc { get; set; }
        public string FilterRawData { get; set; }
        public string CorrectRawData { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
    }
}
