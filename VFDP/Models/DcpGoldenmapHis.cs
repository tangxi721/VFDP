using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpGoldenmapHis
    {
        public string FabId { get; set; }
        public string LotCd { get; set; }
        public string OperId { get; set; }
        public string NormalOperId { get; set; }
        public string EdgeOperId { get; set; }
        public string CdOperId { get; set; }
        public string EqpId { get; set; }
        public string ChuckId { get; set; }
        public string CalcTyp { get; set; }
        public decimal? RefLotCnt { get; set; }
        public decimal? CutoffDay { get; set; }
        public decimal? Damping { get; set; }
        public string ResetDt { get; set; }
        public decimal? Knnrange { get; set; }
        public string ProdId { get; set; }
        public string Inter { get; set; }
        public string Intra { get; set; }
        public string OperatorX { get; set; }
        public decimal? OffsetX { get; set; }
        public string OperatorY { get; set; }
        public decimal? OffsetY { get; set; }
        public decimal? FilterVal { get; set; }
        public decimal? SigmaVal { get; set; }
        public string FilterYn { get; set; }
        public decimal? Knnpercent { get; set; }
        public string FlowId { get; set; }
        public string ReticleId { get; set; }
        public string BiasRemoveFilterYn { get; set; }
        public string CdParaName { get; set; }
        public string CdRelXCoordParaNm { get; set; }
        public string CdRelYCoordParaNm { get; set; }
        public string IntraBiasMonUseYn { get; set; }
        public decimal? IntraBiasMonRangeVal { get; set; }
        public decimal? IntraBiasMonMeasCnt { get; set; }
        public string XVarbIndirOperId { get; set; }
        public string YVarbIndirOperId { get; set; }
        public string XIndirVarbVal { get; set; }
        public string YIndirVarbVal { get; set; }
        public string PassRatioVal { get; set; }
        public string BiasIcansRatio { get; set; }
        public string MaBiasRefProdId { get; set; }
        public string MaBiasRefFlowId { get; set; }
        public string MaGrpId { get; set; }
        public DateTime? CrtDt { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgDt { get; set; }
        public string ChgUserId { get; set; }
        public string RaFilterYn { get; set; }
        public string StepperRecipeId { get; set; }
        public string PassRatioXVal { get; set; }
        public string PassRatioYVal { get; set; }
        public string GoldenYn { get; set; }
        public string EdgeReplaceModelYn { get; set; }
    }
}
