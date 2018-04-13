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
        public static ReportViewModel ReportModelToReportViewModel(ReportModel report)
        {
            ReportViewModel convertedReportModel = new ReportViewModel
            {
                Description = report.Description,
                DescriptionStatus = report.DescriptionStatus,
                LastUpdate = report.LastUpdate
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

        public static CustomerViewModel CustomerModelToCustomerViewModel(CustomerModel customerModel)
        {
            CustomerViewModel convertedCustomer = new CustomerViewModel
            {
                CustomerId = customerModel.CustomerId,
                FirstName = customerModel.FirstName,
                LastName = customerModel.LastName,
                EMail = customerModel.EMail,
                PhoneNumber = customerModel.PhoneNumber,
                Address = AddressModelToAddressViewModel(customerModel.Address),
                Password = PasswordModelToPasswordViewModel(customerModel.Password)
            };

            return convertedCustomer;
        }

        private static PasswordViewModel PasswordModelToPasswordViewModel(PasswordModel passwordModel)
        {
            PasswordViewModel convertedPassword = new PasswordViewModel
            {
                PasswordHash = passwordModel.PasswordHash,
                Salt = passwordModel.Salt
            };

            return convertedPassword;
        }

        private static AddressViewModel AddressModelToAddressViewModel(AddressModel addressModel)
        {
            AddressViewModel convertedAddress = new AddressViewModel
            {
                City = addressModel.City,
                Country = addressModel.Country,
                HouseNumber = addressModel.HouseNumber,
                PostalCode = addressModel.PostalCode,
                StreetName = addressModel.StreetName
            };

            return convertedAddress;
        }


        public static BillViewModel BillModelToBillViewModel(BillModel billModel)
        {
            BillViewModel convertedBill = new BillViewModel()
            {
                BillId = billModel.BillId,
                Amount = billModel.Amount,
                PaymentStatus = billModel.PaymentStatus,
                LastUpdate = billModel.LastUpdate,
            };

            return convertedBill;
        }

        private static BillModel BillViewModelToBillModel(BillViewModel billViewModel)
        {
            BillModel convertedBill = new BillModel
            {
                BillId = billViewModel.BillId,
                Amount = billViewModel.Amount,
                PaymentStatus = billViewModel.PaymentStatus,
                LastUpdate = billViewModel.LastUpdate,
                
            };

            return convertedBill;
        }

        public static ReportModel ReportViewModelToReportModel(ReportViewModel report)
        {
            ReportModel convertedReport = new ReportModel
            {
                Description = report.Description,
                DescriptionStatus = report.DescriptionStatus,
                LastUpdate = report.LastUpdate
            };

            return convertedReport;
        }
    }
}
