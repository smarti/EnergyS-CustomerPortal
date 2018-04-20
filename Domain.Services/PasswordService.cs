using Data;
using Domain.Models;

namespace Domain.Services
{
    public class PasswordService
    {
        private readonly DBContext _context;
        private readonly PasswordDataBySQL _data;

        public PasswordService()
        {
            _context = new DBContext();
            _data = new PasswordDataBySQL(_context);
        }

        public void ChangePassword(CustomerModel customer, string newPassword)
        {
            _data.UpdatePasswordHash(Map.CustomerModelToCustomer(customer), newPassword);
        }
    }
}