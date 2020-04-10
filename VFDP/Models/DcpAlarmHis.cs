using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpAlarmHis
    {
        public string FacId { get; set; }
        public string AlarmId { get; set; }
        public string Timekey { get; set; }
        public DateTime EventTm { get; set; }
        public string EventUserId { get; set; }
        public string EventDesc { get; set; }
        public string AlarmGrpCd { get; set; }
        public string AlarmLevelCd { get; set; }
        public string CtnDesc { get; set; }
        public string ActTyp { get; set; }
        public string ActAttrVal1 { get; set; }
        public string ActAttrVal2 { get; set; }
        public string EqpId { get; set; }
        public string StatCd { get; set; }
        public string LotId { get; set; }
        public string CarrierId { get; set; }
        public string RecipeId { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string ReticleId { get; set; }
        public string WfId { get; set; }
        public string LimitTyp { get; set; }
        public string RsltVal { get; set; }
        public string UpperLimitVal { get; set; }
        public string LowerLimitVal { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public decimal? DcolDataId { get; set; }
    }
}
