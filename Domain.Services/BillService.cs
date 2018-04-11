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
    class BillService
    {
        public List<BillModel> GetAllBills()
        {
            BillDataBySQL _data = new BillDataBySQL();
            List<Customer> customers = _data.GetAllCustomers();
            return customers;
        }
    }
}
