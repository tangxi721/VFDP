using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class MesOperMasMv
    {
        public string FacId { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string CtnDesc { get; set; }
        public string ChkStatCd { get; set; }
        public string ActiveStatCd { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChkoutTm { get; set; }
        public string ChkoutUserId { get; set; }
        public string MidOperTyp { get; set; }
        public string DetOperTyp { get; set; }
        public string OperGrpCd { get; set; }
        public string OperUnitCd { get; set; }
        public string LogonReqYn { get; set; }
        public string DefaultAreaId { get; set; }
        public string MeasTyp { get; set; }
        public string CarrierGrpId { get; set; }
        public string MainOperId { get; set; }
        public string DefaultStkId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public double? CycleTime { get; set; }
        public double? IdleTime { get; set; }
        public double? ProcTime { get; set; }
        public string EqpGrpId { get; set; }
        public string SkipAllowYn { get; set; }
        public string SplitRwkSkipYn { get; set; }
        public string StdAreaId { get; set; }
        public string NpwReturnFlowId { get; set; }
        public string NpwReturnOperId { get; set; }
        public string DcolId { get; set; }
        public string DetAreaId { get; set; }
        public string OperTyp { get; set; }
        public string SdptNm { get; set; }
        public string DefaultZoneNm { get; set; }
        public string GasTyp { get; set; }
        public string PwYn { get; set; }
        public string FutureHoldYn { get; set; }
        public string MoveReplaceOperYn { get; set; }
        public string ChgOperId { get; set; }
        public string JumpPermitOperId { get; set; }
        public double? BatchSize { get; set; }
        public string FamilyCd { get; set; }
        public string R3BakAllowYn { get; set; }
        public string SumryDesc { get; set; }
        public string AddOperTyp { get; set; }
        public string AddDetOperTyp { get; set; }
        public string UniqueInlineTrackYn { get; set; }
        public string MetalYn { get; set; }
        public string SampMeasTyp { get; set; }
        public string SubOperId { get; set; }
        public string NpwTyp { get; set; }
        public string NpwAreaId { get; set; }
        public string ChkItemCd { get; set; }
        public string EventUseTyp { get; set; }
        public string StepSeqVal { get; set; }
        public string WorkTyp { get; set; }
    }
}
