using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsRecipeParamMas
    {
        public decimal RecipeParaId { get; set; }
        public decimal LogsheetId { get; set; }
        public string AreaId { get; set; }
        public string EqpId { get; set; }
        public string Recipe { get; set; }
        public string ParaNm { get; set; }
        public string VirtualParaNm { get; set; }
        public string Remark { get; set; }
    }
}
