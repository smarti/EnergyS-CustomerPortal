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
        public List<Bill> GetAllBillsByCustumer(Customer customer)
        {
            DBContext _context = new DBContext();

            List<Bill> bills = new List<Bill>();

            foreach (Bill bill in _context.Bills)
            {
                if _context.
                bills.Add(bill);
            }

            return bills;
        }
    }
}
