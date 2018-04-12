using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.Models;
using Domain.Services;

namespace Application.Providers
{
    public class ReportProvider
    {
        private ReportService _service;

        public ReportProvider()
        {
            _service = new ReportService();
        }

        public List<ReportViewModel> GetAllReportsByCustomer(CustomerViewModel customer)
        {
            List<ReportModel> reports =
                _service.GetAllReportsByCustomer(Map.CustomerViewModelToCustomerModel(customer));

            List<ReportViewModel> convertedReports = new List<ReportViewModel>();

            foreach (ReportModel report in reports)
            {
                convertedReports.Add(Map.ReportModelToReportViewModel(report));
            }

            return convertedReports;
        }
    }
}
