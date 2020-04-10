using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpWaferMainInf
    {
        public string Prod { get; set; }
        public string ProcFlow { get; set; }
        public string MeasOperId { get; set; }
        public string LotId { get; set; }
        public string WfId { get; set; }
        public string MeasEqpId { get; set; }
        public string MainEqpId { get; set; }
        public string FabId { get; set; }
        public string RecipeId { get; set; }
        public DateTime? StartTm { get; set; }
        public DateTime? EndTm { get; set; }
        public string MainOperId { get; set; }
        public string ProcYn { get; set; }
        public DateTime? CrtTm { get; set; }
        public DateTime? ChgTm { get; set; }
        public string MainChamberId { get; set; }
        public string MainSeqRecipeId { get; set; }
        public string MainProcRecipeId { get; set; }
        public string MainChuckId { get; set; }
        public string MainStepperRecipeId { get; set; }
        public string MainZone { get; set; }
        public string MainHead { get; set; }
    }
}
