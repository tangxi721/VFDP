using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpBiasavgHis
    {
        public string FabId { get; set; }
        public DateTime CrtDt { get; set; }
        public string MainEqpId { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public string MainOperId { get; set; }
        public string NormalOperId { get; set; }
        public string EdgeOperId { get; set; }
        public string IcansOperId { get; set; }
        public string LinkKey { get; set; }
        public string LinkWfKey { get; set; }
        public string RefLotId { get; set; }
        public string RefWfId { get; set; }
        public string RefKey { get; set; }
        public string RefWfKey { get; set; }
        public string ChuckId { get; set; }
        public string RefOrgWfId { get; set; }
        public string FlowId { get; set; }
        public string ReticleId { get; set; }
        public string StepperRecipeId { get; set; }
    }
}
