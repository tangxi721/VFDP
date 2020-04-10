using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolextHis
    {
        public string Tid { get; set; }
        public string AliasNm { get; set; }
        public string Fab { get; set; }
        public string EqpId { get; set; }
        public string ReticleId { get; set; }
        public string RecipeId { get; set; }
        public string PortId { get; set; }
        public string BatchCnt { get; set; }
        public string BatchId { get; set; }
        public string ProcJobId { get; set; }
        public string CarrierId { get; set; }
        public string Prod { get; set; }
        public string ProcFlow { get; set; }
        public string Oper { get; set; }
        public string LotId { get; set; }
        public DateTime CrtTm { get; set; }
        public decimal DcolDataId { get; set; }
    }
}
