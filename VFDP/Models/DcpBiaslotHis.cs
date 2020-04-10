using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpBiaslotHis
    {
        public string FabId { get; set; }
        public string Timekey { get; set; }
        public string MainEqpId { get; set; }
        public string WfId { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public string MainOperId { get; set; }
        public string NormalOperId { get; set; }
        public string EdgeOperId { get; set; }
        public string IcansOperId { get; set; }
        public string LotId { get; set; }
        public string IcansLinkKey { get; set; }
        public string IcansLinkWfKey { get; set; }
        public DateTime? CrtDt { get; set; }
        public string LastRwkTm { get; set; }
        public string ChuckId { get; set; }
        public string IncludeYn { get; set; }
        public string OrgWfId { get; set; }
        public string FlowId { get; set; }
        public string ReticleId { get; set; }
        public string StepperRecipeId { get; set; }
    }
}
