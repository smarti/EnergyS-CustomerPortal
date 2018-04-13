using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Application.Providers;
using Application.ViewModels;

namespace CustomerPortal.API.Controllers
{
    public class ReportController : ApiController
    {
        private ReportProvider _provider;

        public ReportController() : base()
        {
            _provider = new ReportProvider();
        }

        [Route("api/customers/{customerId}/reports")]
        [HttpGet]
        public List<ReportViewModel> GetAllReportsByCustomerId(int customerId)
        {
            List<ReportViewModel> reports = _provider.GetAllReportsByCustomerId(customerId);

            return reports;
        }

        [Route("api/report/add")]
        [HttpPost]
        public void CreateReportByCustomerId(int customerId, string description)
        {
            ReportViewModel report = new ReportViewModel
            {
                DescriptionStatus = "Nieuw",
                Description = description,
                LastUpdate = DateTime.Now
            };

            _provider.CreateReportByCustomerId(customerId, report);
        }
    }
}