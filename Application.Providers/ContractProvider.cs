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
    public class ContractProvider
    {
        private ContractService _service;

        public ContractProvider()
        {
            _service = new ContractService();
        }

        public List<ContractViewModel> GetAllContractsByCustomerId(int customerId)
        {
            CustomerService customerService = new CustomerService();
            CustomerViewModel customer =
                Map.CustomerModelToCustomerViewModel(customerService.GetCustomerById(customerId));

            List<ContractModel> contracts =
                _service.GetAllContractsByCustomer(Map.CustomerViewModelToCustomerModel(customer));

            List<ContractViewModel> convertedContracts = new List<ContractViewModel>();
            foreach (ContractModel contract in contracts)
            {
                convertedContracts.Add(Map.ContractModelToContractViewModel(contract));
            }

            return convertedContracts;
        }
    }
}
