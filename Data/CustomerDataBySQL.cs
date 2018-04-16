using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class CustomerDataBySQL
    {
        private DBContext _context;

        public CustomerDataBySQL(DBContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public Customer GetCustomerByEMail(string eMail)
        {
            List<Customer> customers = new List<Customer>();

            customers.AddRange(_context.Customers.Where(x => x.EMail == eMail));

            if (customers.Count == 0)
                return null;

            return customers[0];
        }
    }
}
