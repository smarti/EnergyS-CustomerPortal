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

        public List<ReportViewModel> GetAllReportsByCustomerId(int customerId)
        {
            CustomerService customerService = new CustomerService();
            CustomerViewModel customer =
                Map.CustomerModelToCustomerViewModel(customerService.GetCustomerById(customerId));


            List<ReportModel> reports =
                _service.GetAllReportsByCustomer(Map.CustomerViewModelToCustomerModel(customer));

            List<ReportViewModel> convertedReports = new List<ReportViewModel>();

            foreach (ReportModel report in reports)
            {
                convertedReports.Add(Map.ReportModelToReportViewModel(report));
            }

            return convertedReports;
        }

        public void CreateReportByCustomerId(int customerId, ReportViewModel report)
        {
            CustomerService customerService = new CustomerService();
            CustomerViewModel customer =
                Map.CustomerModelToCustomerViewModel(customerService.GetCustomerById(customerId));

            _service.CreateReportByCustomer(Map.CustomerViewModelToCustomerModel(customer), Map.ReportViewModelToReportModel(report));
        }
    }
}
