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

        public int CheckCustomerLogin(string eMail, string password)
        {
            int customerId = _service.CheckCustomerLogin(eMail, password);

            return customerId;
        }

        public void ChangeCustomerPassword(int customerId, string oldPassword, string newPassword)
        {
            CustomerViewModel customer = Map.CustomerModelToCustomerViewModel(_service.GetCustomerById(customerId));
            int isAuthorized = _service.CheckCustomerLogin(customer.EMail, oldPassword);

            if (isAuthorized != 0)
            {
                PasswordService passwordService = new PasswordService();

                passwordService.ChangePassword(Map.CustomerViewModelToCustomerModel(customer), newPassword);
            }
        }
    }
}
