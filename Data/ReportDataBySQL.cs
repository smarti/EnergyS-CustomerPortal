using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class ReportDataBySQL
    {
        private readonly DBContext _context;

        public ReportDataBySQL(DBContext context)
        {
            _context = context;
        }

        public List<Report> GetAllReportsByCustomer(Customer customer)
        {
            List<Report> reports = new List<Report>();

            reports.AddRange(_context.Reports.Where(report => report.Customer.CustomerId == customer.CustomerId));

            return reports;
        }
    }
}
