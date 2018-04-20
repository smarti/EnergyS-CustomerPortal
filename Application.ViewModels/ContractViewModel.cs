using System;

namespace Application.ViewModels
{
    public class ContractViewModel
    {
        public int ContractId { get; set; }

        public string Description { get; set; }
        public string ContractStatus { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}