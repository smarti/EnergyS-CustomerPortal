using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Application.ViewModels;

namespace Application.Providers
{
    public static class Map
    {
        public static ReportViewModel ReportModelToReportViewModel(ReportModel reportModel)
        {
            ReportViewModel convertedReportModel = new ReportViewModel
            {
                Description = reportModel.Description,
                DescriptionStatus = reportModel.DescriptionStatus,
                LastUpdate = reportModel.LastUpdate
            };

            return convertedReportModel;
        }

        public static CustomerModel CustomerViewModelToCustomerModel(CustomerViewModel customerViewModel)
        {
            CustomerModel convertedCustomer = new CustomerModel
            {
                CustomerId = customerViewModel.CustomerId,
                FirstName = customerViewModel.FirstName,
                LastName = customerViewModel.LastName,
                EMail = customerViewModel.EMail,
                PhoneNumber = customerViewModel.PhoneNumber,
                Address = AddressViewModelToAddressModel(customerViewModel.Address),
                Password = PasswordViewModelToPasswordModel(customerViewModel.Password)
            };

            return convertedCustomer;
        }

        private static PasswordModel PasswordViewModelToPasswordModel(PasswordViewModel passwordViewModel)
        {
            PasswordModel convertedPassword = new PasswordModel
            {
                PasswordHash = passwordViewModel.PasswordHash,
                Salt = passwordViewModel.Salt
            };

            return convertedPassword;
        }

        private static AddressModel AddressViewModelToAddressModel(AddressViewModel addressViewModel)
        {
            AddressModel convertedAddress = new AddressModel
            {
                City = addressViewModel.City,
                Country = addressViewModel.Country,
                HouseNumber = addressViewModel.HouseNumber,
                PostalCode = addressViewModel.PostalCode,
                StreetName = addressViewModel.StreetName
            };

            return convertedAddress;
        }
    }
}
