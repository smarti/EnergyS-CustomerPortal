using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class BillDataBySQL
    {
        private readonly DBContext Context;

        public BillDataBySQL(DBContext context)
        {
            Context = context;
        }
        public List<Bill> GetAllBillsByCustumer(Customer customer)
        {
            List<Bill> bills = new List<Bill>();

            bills.AddRange(Context.Bills.Where(bill => bill.Customer.CustomerId == customer.CustomerId));

            return bills;
        }
    }
}
