﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ContractModel
    {
        public int ContractId { get; set; }

        public string Description { get; set; }
        public string ContractStatus { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
