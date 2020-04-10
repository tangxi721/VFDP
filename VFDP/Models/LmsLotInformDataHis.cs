using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsLotInformDataHis
    {
        public decimal LotInformId { get; set; }
        public decimal DcolDataId { get; set; }
        public string BatchCnt { get; set; }
        public string Remark { get; set; }
        public DateTime CrtTm { get; set; }
        public string MeasCnt1 { get; set; }
        public string MeasCnt2 { get; set; }
        public string AbnormalMeasYn { get; set; }
    }
}
