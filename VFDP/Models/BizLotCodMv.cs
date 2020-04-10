using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizLotCodMv
    {
        public string FacId { get; set; }
        public string LotCd { get; set; }
        public string CtnDesc { get; set; }
        public string ProdId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public string StepperDeviceCd { get; set; }
        public string TrackDeviceCd { get; set; }
        public string AreaId { get; set; }
        public string PccbStatCd { get; set; }
        public string PccbApplyTm { get; set; }
        public string OwnerCdTyp { get; set; }
        public string RepresentLotCd { get; set; }
        public string MetalTyp { get; set; }
        public string ChkItemCd { get; set; }
        public string NpwTyp { get; set; }
        public string WorkTyp { get; set; }
    }
}
