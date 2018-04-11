using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //Address = customerModel.Address.MapToAddress(),
                //Password = customerModel.Password.MapToPassword()
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
                //Address = customer.Address.MapToAddress(),
                //Password = customer.Password.MapToPassword()
            };

            return convertedCustomer;
        }


    }
}
