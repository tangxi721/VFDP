using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpAreaMas
    {
        public string FabId { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public string OperId { get; set; }
        public string EqpId { get; set; }
        public string ChuckId { get; set; }
        public string ShotX { get; set; }
        public string ShotY { get; set; }
        public DateTime? CrtDt { get; set; }
        public string CrtUsr { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string UpdateUsr { get; set; }
    }
}
