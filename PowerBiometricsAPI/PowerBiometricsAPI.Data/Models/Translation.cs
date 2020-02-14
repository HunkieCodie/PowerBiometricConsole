using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Translation
    {
        public string ObjId { get; set; }
        public string ObjDescription { get; set; }
        public string Arabic { get; set; }
        public string ChineseSimple { get; set; }
        public string ChineseTrad { get; set; }
        public string Dutch { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        public string Fund { get; set; }
        public string German { get; set; }
        public string Hindi { get; set; }
        public string Italian { get; set; }
        public string Japanese { get; set; }
        public string Korean { get; set; }
        public string Portuguese { get; set; }
        public string Russian { get; set; }
        public string Spanish { get; set; }
        public string Swedish { get; set; }
        public string Thai { get; set; }
        public bool? Translated { get; set; }
        public bool? Reviewed { get; set; }
        public bool? Corrected { get; set; }
        public string BranchCode { get; set; }
    }
}
