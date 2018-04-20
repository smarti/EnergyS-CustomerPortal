using Data;
using Domain.Models;

namespace Domain.Services
{
    public class CustomerService
    {
        private readonly DBContext _context;
        private readonly CustomerDataBySQL _data;

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
            if (_data.GetCustomerByEMail(eMail) == null)
                return 0;

            CustomerModel customer = Map.CustomerToCustomerModel(_data.GetCustomerByEMail(eMail));

            if (customer != null && password == customer.Password.PasswordHash)
                return customer.CustomerId;

            return 0;
        }
    }
}