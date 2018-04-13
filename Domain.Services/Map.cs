using System;
using Data.Entities;

namespace Domain.Models
{
    public static class Map
    {
        public static Customer CustomerModelToCustomer(CustomerModel customer)
        {
            Customer convertedCustomer = new Customer
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                EMail = customer.EMail,
                PhoneNumber = customer.PhoneNumber,
                Address = AddressModelToAddress(customer.Address),
                Password = PasswordModelToPassword(customer.Password)
            };

            return convertedCustomer;
        }

        private static Password PasswordModelToPassword(PasswordModel password)
        {
            Password convertedPassword = new Password
            {
                PasswordHash = password.PasswordHash,
                Salt = password.Salt
            };

            return convertedPassword;
        }

        private static Address AddressModelToAddress(AddressModel address)
        {
            Address convertedAddress = new Address
            {
                StreetName = address.StreetName,
                HouseNumber = address.HouseNumber,
                PostalCode = address.PostalCode,
                City = address.City,
                Country = address.Country
            };

            return convertedAddress;
        }

        public static ReportModel ReportToReportModel(Report report)
        {
            ReportModel convertedReport = new ReportModel()
            {
                ReportId = report.ReportId,
                Description = report.Description,
                DescriptionStatus = report.DescriptionStatus,
                LastUpdate = report.LastUpdate
            };

            return convertedReport;
        }

        public static Report ReportModelToReport(ReportModel report)
        {
            Report convertedReport = new Report()
            {
                ReportId = report.ReportId,
                Description = report.Description,
                DescriptionStatus = report.DescriptionStatus,
                LastUpdate = report.LastUpdate
            };

            return convertedReport;
        }


        public static BillModel BillToBillModel(Bill bill)
        {
            BillModel convertedBill = new BillModel()
            {
                BillId = bill.BillId,
                Amount = bill.Amount,
                PaymentStatus = bill.PaymentStatus,
                LastUpdate = bill.LastUpdate
            };

            return convertedBill;

        }

        private static Bill BillModelToBill(BillModel bill)
        {
            Bill convertedBill = new Bill
            {
                BillId = bill.BillId,
                Amount = bill.Amount,
                PaymentStatus = bill.PaymentStatus,
                LastUpdate = bill.LastUpdate
            };

            return convertedBill;
        }

        public static CustomerModel CustomerToCustomerModel(Customer customer)
        {
            CustomerModel convertedCustomer = new CustomerModel
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                EMail = customer.EMail,
                PhoneNumber = customer.PhoneNumber,
                Address = AddressToAddressModel(customer.Address),
                Password = PasswordToPasswordModel(customer.Password)
            };

            return convertedCustomer;
        }

        private static PasswordModel PasswordToPasswordModel(Password password)
        {
            PasswordModel convertedPassword = new PasswordModel
            {
                PasswordHash = password.PasswordHash,
                Salt = password.Salt
            };

            return convertedPassword;
        }

        private static AddressModel AddressToAddressModel(Address address)
        {
            AddressModel convertedAddress = new AddressModel
            {
                StreetName = address.StreetName,
                HouseNumber = address.HouseNumber,
                PostalCode = address.PostalCode,
                City = address.City,
                Country = address.Country
            };
            
            return convertedAddress;
        }

        public static MeterReadingModel MeterReadingToMeterReadingModel(MeterReading meterReading)
        {
            MeterReadingModel convertMeterReading = new MeterReadingModel()
            {
                MeterReadingId = meterReading.MeterReadingId,
                CurrentReading = meterReading.CurrentReading,
                LastUpdate = meterReading.LastUpdate,

            };

            return convertMeterReading;

        }
        
    }
}