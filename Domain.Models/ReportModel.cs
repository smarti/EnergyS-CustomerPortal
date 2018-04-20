using System;

namespace Domain.Models
{
    public class ReportModel
    {
        public int ReportId { get; set; }
        public string Description { get; set; }
        public string DescriptionStatus { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}