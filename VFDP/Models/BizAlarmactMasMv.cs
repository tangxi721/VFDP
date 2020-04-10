using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizAlarmactMasMv
    {
        public string FacId { get; set; }
        public string AlarmId { get; set; }
        public string AlarmGrpCd { get; set; }
        public string AlarmLvlCd { get; set; }
        public string CtnDesc { get; set; }
        public string GoalAreaId { get; set; }
        public string Intval { get; set; }
        public string ActTyp { get; set; }
        public string ActAttrVal1 { get; set; }
        public string ActAttrVal2 { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public string ActAttrVal3 { get; set; }
        public string ActAttrVal4 { get; set; }
    }
}
