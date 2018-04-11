﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public AddressModel Address { get; set; }
        public PasswordModel Password { get; set; }

        public List<BillModel> Bills { get; set; }
        public List<ContractModel> Contracts { get; set; }
        public List<MeterReadingModel> MeterReadings { get; set; }
        public List<ReportModel> Reports { get; set; }
    }
}