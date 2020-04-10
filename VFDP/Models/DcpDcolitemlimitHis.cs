using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolitemlimitHis
    {
        public string ProdId { get; set; }
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string DcolItemCd { get; set; }
        public string Timekey { get; set; }
        public DateTime? EventTm { get; set; }
        public string EventCd { get; set; }
        public string EventUserId { get; set; }
        public string EventDesc { get; set; }
        public string TgtVal { get; set; }
        public string MinLimitVal { get; set; }
        public string MaxLimitVal { get; set; }
        public string LowerCtrlLimitVal { get; set; }
        public string UpperCtrlLimitVal { get; set; }
        public string LowerScreenLimitVal { get; set; }
        public string UpperScreenLimitVal { get; set; }
        public string UpperFatalLimitVal { get; set; }
        public string LowerFatalLimitVal { get; set; }
        public string FatalActCd { get; set; }
        public string UpperErrLimitVal { get; set; }
        public string LowerErrLimitVal { get; set; }
        public string ErrActCd { get; set; }
        public string UpperCautLimitVal { get; set; }
        public string LowerCautLimitVal { get; set; }
        public string CautActCd { get; set; }
        public string CtrlActCd { get; set; }
        public string UpperEngrLimitVal { get; set; }
        public string LowerEngrLimitVal { get; set; }
        public string EngrActCd { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string UpperRwkLimitVal { get; set; }
        public string LowerRwkLimitVal { get; set; }
        public string RwkActCd { get; set; }
        public string SpcRuleChkYn { get; set; }
        public string ActCd { get; set; }
        public string OutPointVal { get; set; }
        public string UpperSndrclLimitVal { get; set; }
        public string LowerSndrclLimitVal { get; set; }
        public string UpperChgstrLimitVal { get; set; }
        public string LowerChgstrLimitVal { get; set; }
    }
}
