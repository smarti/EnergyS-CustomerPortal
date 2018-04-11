using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data;
using Domain.Models;

namespace Domain.Services
{
    public class BillService
    {
        private DBContext _context;
        private BillDataBySQL _data;
        public BillService()
        {
            _context = new DBContext();
            _data = new BillDataBySQL(_context);
        }

        public List<BillModel> GetAllBillsByCustomer(CustomerModel customer)
        {
            List<Bill> bills = _data.GetAllBillsByCustumer(Map.CustomerModelToCustomer(customer));

            List<BillModel> convertedBills = new List<BillModel>();

            foreach (Bill bill in bills)
            {
                convertedBills.Add(Map.BillToBillModel(bill));
            }

            return convertedBills;
        }
    }
}
