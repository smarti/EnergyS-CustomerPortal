using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class ContractDataBySQL
    {
        private readonly DBContext Context;

        public ContractDataBySQL(DBContext context)
        {
            Context = context;
        }
        public List<Contract> GetAllContractsByCustomer(Customer customer)
        {
            List<Contract> contracts = new List<Contract>();

            contracts.AddRange(Context.Contracts.Where(contract => contract.Customer.CustomerId == customer.CustomerId));

            return contracts;
        }

        public void CreateContract(Contract contract)
        {
            contract.Customer = Context.Customers.Find(contract.Customer.CustomerId);

            Context.Contracts.Add(contract);

            Context.SaveChangesAsync();
        }
    }
}
