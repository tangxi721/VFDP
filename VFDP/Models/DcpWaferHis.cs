using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpWaferHis
    {
        public string WfId { get; set; }
        public string EventNm { get; set; }
        public DateTime StartTm { get; set; }
        public DateTime? EndTm { get; set; }
        public DateTime? RcvStartTm { get; set; }
        public DateTime? RcvEndTm { get; set; }
        public string EqpId { get; set; }
        public string ModuleId { get; set; }
        public string ModuleNm { get; set; }
        public string ResourceTyp { get; set; }
        public string ResourceGroup { get; set; }
        public string LotId { get; set; }
        public string Prod { get; set; }
        public string Product { get; set; }
        public string ProcessFlow { get; set; }
        public string OperId { get; set; }
        public string OperDesc { get; set; }
        public string SeqRecipeId { get; set; }
        public string RecipeId { get; set; }
        public string CassetteId { get; set; }
        public string CassetteSlot { get; set; }
        public string State { get; set; }
        public string OnlineMode { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
