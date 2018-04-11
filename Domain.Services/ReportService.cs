using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Data;
using Data.Entities;

namespace Domain.Services
{
    public class ReportService
    {
        private DBContext _context;
        private ReportDataBySQL _data;

        public ReportService()
        {
            _context = new DBContext();
            _data = new ReportDataBySQL(_context);
        }

        public List<ReportModel> GetAllReportsByCustomer(CustomerModel customer)
        {
            List<Report> reports = _data.GetAllReportsByCustomer(Map.CustomerModelToCustomer(customer));

            List<ReportModel> convertedReports = new List<ReportModel>();

            foreach (Report report in reports)
            {
                convertedReports.Add();
            }

            return convertedReports;
        }
    }
}
