using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int CheckCustomerLogin(string eMail, string password)
        {
            int customerId = _service.CheckCustomerLogin(eMail, password);

            return customerId;
        }
    }
}
