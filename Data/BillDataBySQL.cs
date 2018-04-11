using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    class BillDataBySQL
    {
        private readonly DBContext Context;

        public BillDataBySQL(DBContext context)
        {
            Context = context;
        }
        public List<Bill> GetAllBillsByCustumer(Customer customer)
        {
            List<Bill> bills = new List<Bill>();

            foreach (Bill bill in Context.Bills)
            {
                if (bill.Customer == customer)
                {
                    bills.Add(bill);
                }
                
            }

            return bills;
        }
    }
}
