using System.Collections.Generic;
using System.Linq;
using Data.Entities;

namespace Data
{
    public class ReportDataBySQL
    {
        private readonly DBContext _context;

        public ReportDataBySQL(DBContext context)
        {
            _context = context;
            _context.Set<Report>();
        }

        public List<Report> GetAllReportsByCustomer(Customer customer)
        {
            List<Report> reports = new List<Report>();

            reports.AddRange(_context.Reports.Where(report => report.Customer.CustomerId == customer.CustomerId));

            return reports;
        }

        public void CreateReport(Report report)
        {
            report.Customer = _context.Customers.Find(report.Customer.CustomerId);

            _context.Reports.Add(report);

            _context.SaveChangesAsync();
        }
    }
}