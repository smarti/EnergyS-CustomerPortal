using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Models;

namespace Domain.Services
{
    public class PasswordService
    {
        private DBContext _context;
        private PasswordDataBySQL _data;

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
