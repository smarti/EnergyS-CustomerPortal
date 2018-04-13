using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using Domain.Models;

namespace Domain.Services
{
    public class MeterReadingService
    {
        private DBContext _context;
        private MeterReadingDataBySQL _data;

        public MeterReadingService()
        {
            _context = new DBContext();
            _data = new MeterReadingDataBySQL(_context);
        }

        public List<MeterReadingModel> GetAllMeterReadingsByCustomer(CustomerModel customer)
        {
            List<MeterReading> meterReadings = _data.GetAllMeterReadingsByCustomer(Map.CustomerModelToCustomer(customer));

            List<MeterReadingModel> convertedMeterReadings = new List<MeterReadingModel>();

            foreach (MeterReading meterReading in meterReadings)
            {
                convertedMeterReadings.Add(Map.MeterReadingToMeterReadingModel(meterReading));
            }

            return convertedMeterReadings;
        }
    }
}
