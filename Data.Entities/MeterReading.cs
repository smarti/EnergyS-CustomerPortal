using System;

namespace Data.Entities
{
    public class MeterReading
    {
        //primary key
        public int MeterReadingId { get; set; }

        public int CurrentReading { get; set; }
        public DateTime LastUpdate { get; set; }

        // Foreign Keys
        public virtual Customer Customer { get; set; }
    }
}