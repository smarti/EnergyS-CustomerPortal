using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ReportModel
    {
        public ReportModel(int reportId, string description, string descriptionStatus, DateTime lastUpdate)
        {
            ReportId = reportId;
            Description = description;
            DescriptionStatus = descriptionStatus;
            LastUpdate = lastUpdate;
        }

        public int ReportId { get; set; }
        public string Description { get; set; }
        public string DescriptionStatus { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
