using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpScanrlotHis
    {
        public string FabId { get; set; }
        public string Timekey { get; set; }
        public string EqpId { get; set; }
        public string MsgAlias { get; set; }
        public string DataSeq { get; set; }
        public string OrgTyp { get; set; }
        public string DestId { get; set; }
        public string CtrlJobId { get; set; }
        public string ProcSeq { get; set; }
        public string EqpIpAddr { get; set; }
        public string ReticleId { get; set; }
        public string SubRecipeId { get; set; }
        public string RecipeId { get; set; }
        public string PortNo { get; set; }
        public decimal? BatchCnt { get; set; }
        public string BatchId { get; set; }
        public string ProcJobId { get; set; }
        public string CarrierId { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string LotId { get; set; }
        public string WfId { get; set; }
        public string ChuckId { get; set; }
        public DateTime? CrtDt { get; set; }
        public string OrgWfId { get; set; }
        public string SlotId { get; set; }
    }
}
