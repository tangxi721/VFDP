using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsInformDataTrx
    {
        public decimal InformId { get; set; }
        public string FacId { get; set; }
        public string AreaId { get; set; }
        public string EqpId { get; set; }
        public string Title { get; set; }
        public string Ctn { get; set; }
        public string UserNm { get; set; }
        public DateTime CrtTm { get; set; }
    }
}
