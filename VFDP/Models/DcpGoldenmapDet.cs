using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpGoldenmapDet
    {
        public string FabId { get; set; }
        public string LotCd { get; set; }
        public string OperId { get; set; }
        public string NormalOperId { get; set; }
        public string EdgeOperId { get; set; }
        public string EqpId { get; set; }
        public string ChuckId { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string ReticleId { get; set; }
        public string StepperRecipeId { get; set; }
        public string TestNo { get; set; }
        public string Fieldx { get; set; }
        public string Fieldy { get; set; }
        public string TgtX { get; set; }
        public string TgtY { get; set; }
        public string GoldenXVal { get; set; }
        public string GoldenYVal { get; set; }
        public string GoldenXTyp { get; set; }
        public string GoldenYTyp { get; set; }
        public string ParaTyp { get; set; }
        public DateTime? CrtDt { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgDt { get; set; }
        public string ChgUserId { get; set; }
    }
}
