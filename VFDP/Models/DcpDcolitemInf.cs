using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolitemInf
    {
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string DcolItemCd { get; set; }
        public string DataTyp { get; set; }
        public decimal? DcsiteCnt { get; set; }
        public string DcsiteNm { get; set; }
        public string TgtVal { get; set; }
        public string MinLimitVal { get; set; }
        public string MaxLimitVal { get; set; }
        public string LowerCtrlLimitVal { get; set; }
        public string UpperCtrlLimitVal { get; set; }
        public string LowerScreenLimitVal { get; set; }
        public string UpperScreenLimitVal { get; set; }
        public string ObjItemNm { get; set; }
        public string DcolTyp { get; set; }
        public decimal? ItemSeq { get; set; }
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
        public string ResrcS1PersonCtn { get; set; }
        public string ResrcS1Desc { get; set; }
        public string ResrcS2PersonCtn { get; set; }
        public string ResrcS2Desc { get; set; }
        public string ResrcS3PersonCtn { get; set; }
        public string ResrcS3Desc { get; set; }
        public string OutofspecChkCtn { get; set; }
        public decimal? UnitCnt { get; set; }
        public string SlotNo { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string SpcRuleChkYn { get; set; }
        public string DispOptTyp { get; set; }
        public string AliasItemNm { get; set; }
        public string DcolItemCatgCd { get; set; }
        public string ParentDcolItemNm { get; set; }
        public string PointSeq { get; set; }
        public string RenmDcolItemCd { get; set; }
        public decimal? DispSeq { get; set; }
    }
}
