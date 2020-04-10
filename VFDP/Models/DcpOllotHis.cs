using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpOllotHis
    {
        public string FabId { get; set; }
        public string Timekey { get; set; }
        public string EqpId { get; set; }
        public string RecovYn { get; set; }
        public string SubjId { get; set; }
        public string DataSeq { get; set; }
        public string OrgTyp { get; set; }
        public string DestId { get; set; }
        public string SkipYn { get; set; }
        public string CtrlJobId { get; set; }
        public string ProcSeq { get; set; }
        public string ReticleId { get; set; }
        public string RecipeId { get; set; }
        public string PortNo { get; set; }
        public string BatchCnt { get; set; }
        public string BatchId { get; set; }
        public string ProcJobId { get; set; }
        public string CarrierId { get; set; }
        public string LotType { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string MainOperId { get; set; }
        public string NormalOperId { get; set; }
        public string EdgeOperId { get; set; }
        public string LotId { get; set; }
        public string LinkKey { get; set; }
        public DateTime? CrtDt { get; set; }
        public string MainEqpId { get; set; }
        public string StepperRecipeId { get; set; }
    }
}
