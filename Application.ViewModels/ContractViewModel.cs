using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
