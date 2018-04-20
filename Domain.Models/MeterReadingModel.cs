using System;

namespace Domain.Models
{
    public class MeterReadingModel
    {
        public int MeterReadingId { get; set; }

        public int CurrentReading { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}