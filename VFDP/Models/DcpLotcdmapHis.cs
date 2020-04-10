using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpLotcdmapHis
    {
        public string FabId { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public decimal? WfPitchXSize { get; set; }
        public decimal? WfPitchYSize { get; set; }
        public decimal? MapOffsetXVal { get; set; }
        public decimal? MapOffsetYVal { get; set; }
        public decimal? ShotXCnt { get; set; }
        public decimal? ShotYCnt { get; set; }
        public string WfMapXCoord { get; set; }
        public string WfMapYCoord { get; set; }
        public string ZOffsetVal { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
    }
}
