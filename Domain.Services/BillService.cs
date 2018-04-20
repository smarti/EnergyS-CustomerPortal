using System.Collections.Generic;
using Data;
using Data.Entities;
using Domain.Models;

namespace Domain.Services
{
    public class BillService
    {
        private readonly DBContext _context;
        private readonly BillDataBySQL _data;

        public BillService()
        {
            _context = new DBContext();
            _data = new BillDataBySQL(_context);
        }

        public List<BillModel> GetAllBillsByCustomer(CustomerModel customer)
        {
            List<Bill> bills = _data.GetAllBillsByCustumer(Map.CustomerModelToCustomer(customer));

            List<BillModel> convertedBills = new List<BillModel>();

            foreach (Bill bill in bills) convertedBills.Add(Map.BillToBillModel(bill));

            return convertedBills;
        }
    }
}