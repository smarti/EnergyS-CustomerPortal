using System;

namespace Application.ViewModels
{
    public class MeterReadingViewModel
    {
        public int MeterReadingId { get; set; }

        public int CurrentReading { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}