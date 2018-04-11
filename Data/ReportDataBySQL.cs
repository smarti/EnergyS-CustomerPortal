using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    class ReportDataBySQL
    {
        private readonly DBContext Context;

        public ReportDataBySQL(DBContext context)
        {
            Context = context;
        }

        public List<Report> GetAllReportsByCustomer(Customer customer)
        {
            List<Report> reports = new List<Report>();

            foreach (Report report in Context.Reports)
            {
                if (report.Customer == customer)
                {
                    reports.Add(report);
                }
            }

            return reports;
        }
    }
}
