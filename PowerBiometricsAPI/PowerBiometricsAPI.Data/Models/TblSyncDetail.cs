using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class TblSyncDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Ftpid { get; set; }
        public string Ftpconfiguration { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string FtpaccessCode { get; set; }
        public string FtpcompanyCode { get; set; }
        public string FtpbranchCode { get; set; }
        public bool? AllowDataUpload { get; set; }
        public bool? AllowDataDownload { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string BranchCode { get; set; }
    }
}
