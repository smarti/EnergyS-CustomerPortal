using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class MeterReadingDataBySQL
    {
        private readonly DBContext _context;

        public MeterReadingDataBySQL(DBContext context)
        {
            _context = context;
        }

        public List<MeterReading> GetAllMeterReadingsByCustomer(Customer customer)
        {
            List<MeterReading> meterReadings = new List<MeterReading>();

            meterReadings.AddRange(_context.MeterReadings.Where(meterReading => meterReading.Customer.CustomerId == customer.CustomerId));

            return meterReadings;
        }
    }
}
