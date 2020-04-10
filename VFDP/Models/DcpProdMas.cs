using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpProdMas
    {
        public string FabId { get; set; }
        public string ProdId { get; set; }
        public string Cmt { get; set; }
        public string ChkStatCd { get; set; }
        public string ActiveStatCd { get; set; }
        public string ProduceTyp { get; set; }
        public string ProdTyp { get; set; }
        public decimal? WfQty { get; set; }
        public string FlowId { get; set; }
        public string FamilyCd { get; set; }
        public string TechCd { get; set; }
        public string DenTyp { get; set; }
        public string Typ1 { get; set; }
        public string Typ2 { get; set; }
        public string GenCd { get; set; }
        public string OrganizVal { get; set; }
        public string LotCd { get; set; }
        public string ReturnProdId { get; set; }
        public string RetrunFlowId { get; set; }
        public string ReturnOperId { get; set; }
        public string FrFabId { get; set; }
    }
}
