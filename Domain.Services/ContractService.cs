using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using Domain.Models;

namespace Domain.Services
{
    public class ContractService
    {
        private DBContext _context;
        private ContractDataBySQL _data;

        public ContractService()
        {
            _context = new DBContext();
            _data = new ContractDataBySQL(_context);
        }

        public List<ContractModel> GetAllContractsByCustomer(CustomerModel customer)
        {
            List<Contract> contracts = _data.GetAllContractsByCustomer(Map.CustomerModelToCustomer(customer));

            List<ContractModel> convertedContracts = new List<ContractModel>();

            foreach (Contract contract in contracts)
            {
                convertedContracts.Add(Map.ContractToContractModel(contract));
            }

            return convertedContracts;
        }
    }
}
