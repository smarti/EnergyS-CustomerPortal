using System.Collections.Generic;
using Application.ViewModels;
using Domain.Models;
using Domain.Services;

namespace Application.Providers
{
    public class ContractProvider
    {
        private readonly ContractService _service;

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
                convertedContracts.Add(Map.ContractModelToContractViewModel(contract));

            return convertedContracts;
        }

        public void CreateContractByCustomerId(int customerId, ContractViewModel contract)
        {
            CustomerService customerService = new CustomerService();
            CustomerViewModel customer =
                Map.CustomerModelToCustomerViewModel(customerService.GetCustomerById(customerId));

            _service.CreateContractByCustomer(Map.CustomerViewModelToCustomerModel(customer),
                Map.ContractViewModelToContractModel(contract));
        }
    }
}