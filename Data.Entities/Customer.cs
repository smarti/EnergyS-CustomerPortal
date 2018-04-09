using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public Address AddressId { get; set; }
        public Contract ContractId { get; set; }
        public MeterReading MeterReadingId { get; set; }
        public Report ReportId { get; set; }
        public Password PasswordId { get; set; }
        public Bill BillId { get; set; }
        public DateTime Valid_From { get; set; }
        public DateTime Valid_Through { get; set; }
        public DateTime Last_Update { get; set; }
    }
}
