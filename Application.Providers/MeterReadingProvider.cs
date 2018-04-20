using System.Collections.Generic;
using Application.ViewModels;
using Domain.Models;
using Domain.Services;

namespace Application.Providers
{
    public class MeterReadingProvider
    {
        private readonly MeterReadingService _service;

        public MeterReadingProvider()
        {
            _service = new MeterReadingService();
        }

        public List<MeterReadingViewModel> GetAllMeterReadingsByCustomerId(int customerId)
        {
            CustomerService customerService = new CustomerService();
            CustomerViewModel customer =
                Map.CustomerModelToCustomerViewModel(customerService.GetCustomerById(customerId));

            List<MeterReadingModel> meterReadings =
                _service.GetAllMeterReadingsByCustomer(Map.CustomerViewModelToCustomerModel(customer));

            List<MeterReadingViewModel> convertedMeterReadings = new List<MeterReadingViewModel>();
            foreach (MeterReadingModel meterReading in meterReadings)
                convertedMeterReadings.Add(Map.MeterReadingModelToMeterReadingViewModel(meterReading));

            return convertedMeterReadings;
        }
    }
}