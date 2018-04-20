using System;

namespace Data.Entities
{
    public class Report
    {
        //primary key
        public int ReportId { get; set; }

        public string Description { get; set; }
        public string DescriptionStatus { get; set; }
        public DateTime LastUpdate { get; set; }

        // Foreign Keys
        public virtual Customer Customer { get; set; }
    }
}