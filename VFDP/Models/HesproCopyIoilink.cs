using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class HesproCopyIoilink
    {
        public string Factoryname { get; set; }
        public string Productspecname { get; set; }
        public string Processflowname { get; set; }
        public string Targetproductspecname { get; set; }
        public string Targetprocessflowname { get; set; }
        public string Ioiactionflag { get; set; }
        public DateTime? CreateTime { get; set; }
        public decimal CreateSeq { get; set; }
        public string Lock { get; set; }
    }
}
