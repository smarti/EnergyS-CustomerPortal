using System.Collections.Generic;
using Data;
using Data.Entities;
using Domain.Models;

namespace Domain.Services
{
    public class ReportService
    {
        private readonly DBContext _context;
        private readonly ReportDataBySQL _data;

        public ReportService()
        {
            _context = new DBContext();
            _data = new ReportDataBySQL(_context);
        }

        public List<ReportModel> GetAllReportsByCustomer(CustomerModel customer)
        {
            List<Report> reports = _data.GetAllReportsByCustomer(Map.CustomerModelToCustomer(customer));

            List<ReportModel> convertedReports = new List<ReportModel>();

            foreach (Report report in reports) convertedReports.Add(Map.ReportToReportModel(report));

            return convertedReports;
        }

        public void CreateReportByCustomer(CustomerModel customer, ReportModel report)
        {
            Report convertedReport = Map.ReportModelToReport(report);
            convertedReport.Customer = Map.CustomerModelToCustomer(customer);

            _data.CreateReport(convertedReport);
        }
    }
}