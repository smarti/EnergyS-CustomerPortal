using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
   public class MeterReadingViewModel
    {
        public int MeterReadingId { get; set; }

        public int CurrentReading { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
