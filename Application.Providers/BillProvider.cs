using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.Models;
using Domain.Services;

namespace Application.Providers
{
   public class BillProvider
    {
        private BillService _service;

        public BillProvider()
        {
            _service = new BillService();
        }

        public List<BillViewModel> GetAlllBillsByCustomerId(int customerId)
        {
            CustomerService customerService = new CustomerService();
            CustomerViewModel customer =
                Map.CustomerModelToCustomerViewModel(customerService.GetCustomerById(customerId));

            List<BillModel> bills =
                _service.GetAllBillsByCustomer(Map.CustomerViewModelToCustomerModel(customer));

            List<BillViewModel> convertedBills = new List<BillViewModel>();
            foreach (BillModel bill in bills)
            {
                convertedBills.Add(Map.BillModelToBillViewModel(bill));
            }

            return convertedBills;
        }
    }
}
