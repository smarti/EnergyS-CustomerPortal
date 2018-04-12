using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Application.Providers;
using Application.ViewModels;

namespace CustomerPortal.API.Controllers
{
    [Route("api/{customerId}/reports")]
    public class ReportController : ApiController
    {
        private ReportProvider _provider;

        public ReportController() : base()
        {
            _provider = new ReportProvider();
        }

        [HttpGet]
        public List<ReportViewModel> GetAllReportsByCustomer(int customerId)
        {
            CustomerViewModel customer = new CustomerViewModel { CustomerId = customerId };

            List<ReportViewModel> reports = _provider.GetAllReportsByCustomer(customer);

            return reports;
        }
    }
}