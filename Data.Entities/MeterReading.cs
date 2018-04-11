using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class MeterReading
    {
        //primary key
        public int MeterReadingId { get; set; }

        public int MeterStand { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
