using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.Services;

namespace Application.Providers
{
    public class CustomerProvider
    {
        private CustomerService _service;

        public CustomerProvider()
        {
            _service = new CustomerService();
        }

        public CustomerViewModel GetCustomerById(int customerId)
        {
            return Map.CustomerModelToCustomerViewModel(_service.GetCustomerById(customerId));
        }
    }
}
