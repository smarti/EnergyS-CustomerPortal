﻿using System.Collections.Generic;
using System.Linq;
using Data.Entities;

namespace Data
{
    public class ContractDataBySQL
    {
        private readonly DBContext _context;

        public ContractDataBySQL(DBContext context)
        {
            _context = context;
        }

        public List<Contract> GetAllContractsByCustomer(Customer customer)
        {
            List<Contract> contracts = new List<Contract>();

            contracts.AddRange(
                _context.Contracts.Where(contract => contract.Customer.CustomerId == customer.CustomerId));

            return contracts;
        }

        public void CreateContract(Contract contract)
        {
            contract.Customer = _context.Customers.Find(contract.Customer.CustomerId);

            _context.Contracts.Add(contract);

            _context.SaveChangesAsync();
        }
    }
}