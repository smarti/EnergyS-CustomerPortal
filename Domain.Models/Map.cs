﻿using System;
using Data.Entities;

namespace Domain.Models
{
    public static class Map
    {
        public static Customer CustomerModelToCustomer(CustomerModel customerModel)
        {
            Customer convertedCustomer = new Customer
            {
                CustomerId = customerModel.CustomerId,
                FirstName = customerModel.FirstName,
                LastName = customerModel.LastName,
                EMail = customerModel.EMail,
                PhoneNumber = customerModel.PhoneNumber,
                Address = AddressModelToAddress(customerModel.Address),
                Password = PasswordModelToPassword(customerModel.Password)
            };

            return convertedCustomer;
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

        private static Password PasswordModelToPassword(PasswordModel customerModelPassword)
        {
            throw new NotImplementedException();
        }

        private static PasswordModel PasswordToPasswordModel(Password customerPassword)
        {
            throw new NotImplementedException();
        }

        private static Address AddressModelToAddress(AddressModel customerModelAddress)
        {
            throw new NotImplementedException();
        }

        private static AddressModel AddressToAddressModel(Address customerAddress)
        {
            throw new NotImplementedException();
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
    }
}