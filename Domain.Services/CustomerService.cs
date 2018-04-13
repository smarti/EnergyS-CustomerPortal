using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Models;

namespace Domain.Services
{
    public class CustomerService
    {
        private DBContext _context;
        private CustomerDataBySQL _data;

        public CustomerService()
        {
            _context = new DBContext();
            _data = new CustomerDataBySQL(_context);
        }

        public CustomerModel GetCustomerById(int customerId)
        {
            return Map.CustomerToCustomerModel(_data.GetCustomerById(customerId));
        }

        public int CheckCustomerLogin(string eMail, string password)
        {
            CustomerModel customer = Map.CustomerToCustomerModel(_data.GetCustomerByEMail(eMail));

            if (password == customer.Password.PasswordHash)
            {
                return customer.CustomerId;
            }

            return 0;
        }
    }
}
