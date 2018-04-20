using System.Collections.Generic;
using Data;
using Data.Entities;
using Domain.Models;

namespace Domain.Services
{
    public class ContractService
    {
        private readonly DBContext _context;
        private readonly ContractDataBySQL _data;

        public ContractService()
        {
            _context = new DBContext();
            _data = new ContractDataBySQL(_context);
        }

        public List<ContractModel> GetAllContractsByCustomer(CustomerModel customer)
        {
            List<Contract> contracts = _data.GetAllContractsByCustomer(Map.CustomerModelToCustomer(customer));

            List<ContractModel> convertedContracts = new List<ContractModel>();

            foreach (Contract contract in contracts) convertedContracts.Add(Map.ContractToContractModel(contract));

            return convertedContracts;
        }

        public void CreateContractByCustomer(CustomerModel customer, ContractModel contract)
        {
            Contract convertedContract = Map.ContractModelToContract(contract);
            convertedContract.Customer = Map.CustomerModelToCustomer(customer);

            _data.CreateContract(convertedContract);
        }
    }
}