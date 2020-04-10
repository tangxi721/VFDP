using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpIcanslotHis
    {
        public string FabId { get; set; }
        public string ActTm { get; set; }
        public string ActEqpId { get; set; }
        public string EnvNm { get; set; }
        public string SendLocId { get; set; }
        public string SendProcId { get; set; }
        public string RecvProcId { get; set; }
        public string CmdVal { get; set; }
        public string MsgId { get; set; }
        public string DcolTyp { get; set; }
        public string ActualTm { get; set; }
        public string RecovYn { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string ActRteId { get; set; }
        public string ActOperId { get; set; }
        public string MeasRteId { get; set; }
        public string MeasOperId { get; set; }
        public string MeasEqpId { get; set; }
        public string SetId { get; set; }
        public string SetVer { get; set; }
        public string CrtUserId { get; set; }
        public string Cmt { get; set; }
        public string ZoneCd { get; set; }
        public string SampLotId { get; set; }
        public string RwkYn { get; set; }
        public string ReticleId { get; set; }
        public string SpecOutTyp { get; set; }
        public string RecipeId { get; set; }
        public string LotCd { get; set; }
        public string BasePlanId { get; set; }
        public string PmsYn { get; set; }
        public string LotId { get; set; }
        public string LinkKey { get; set; }
        public DateTime? CrtDt { get; set; }
        public string MainOperId { get; set; }
        public string NormalOperId { get; set; }
        public string EdgeOperId { get; set; }
        public string IcansOperId { get; set; }
        public string MainEqpId { get; set; }
        public string LastRwkTm { get; set; }
        public string FlowId { get; set; }
        public string StepperRecipeId { get; set; }
    }
}
