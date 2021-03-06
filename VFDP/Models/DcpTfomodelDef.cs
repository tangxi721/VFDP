﻿using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpTfomodelDef
    {
        public string FacId { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string MainOperId { get; set; }
        public string EqpGrpId { get; set; }
        public string RwkFlowId { get; set; }
        public string RwkOperId { get; set; }
        public string RwkLimitCnt { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
