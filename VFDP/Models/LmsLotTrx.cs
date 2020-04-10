using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsLotTrx
    {
        public decimal Rawid { get; set; }
        public string EqpId { get; set; }
        public string ChId { get; set; }
        public string LotId { get; set; }
        public string Recipe { get; set; }
        public string Oper { get; set; }
        public string OperDesc { get; set; }
        public string Prod { get; set; }
        public string ProcFlow { get; set; }
        public string LotTyp { get; set; }
        public string InQty { get; set; }
        public string OutQty { get; set; }
        public string PortNm { get; set; }
        public string LoadDtts { get; set; }
        public string JobStartDtts { get; set; }
        public string JobEndDtts { get; set; }
        public string UnloadDtts { get; set; }
        public string ProcTm { get; set; }
        public string PitchTm { get; set; }
        public string IdleTm { get; set; }
        public string InMoveTm { get; set; }
        public string OutMoveTm { get; set; }
        public string AutoMove { get; set; }
        public string OhtMode { get; set; }
        public string ProcR2r { get; set; }
        public string MoveInUser { get; set; }
        public string MoveOutUser { get; set; }
        public string Batch { get; set; }
        public string BatchZone { get; set; }
        public string ReticleNm { get; set; }
        public DateTime CrtDtts { get; set; }
        public string LatestEventNm { get; set; }
        public string StepperRecipe { get; set; }
        public string FoupId { get; set; }
        public string EqpIdTemp { get; set; }
    }
}
